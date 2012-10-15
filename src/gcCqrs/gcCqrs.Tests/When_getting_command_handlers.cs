using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using GeniusCode.Cqrs.Handlers;
using NUnit.Framework;
using Rhino.Mocks;

namespace gcCqrs.Tests
{
    [TestFixture]
    public class When_getting_command_handlers : SpecificationBase
    {
        private string _value;
        private MyCommand _command;
        private MyCommandHandler _handler;
        private IGenericCommandHandlerFactory _fac;
        private ReflectionGenericCommandHandlerAdapter _adapter;
        private IEnumerable<ICommandHandlerInfo> _hanlderInfos;

        public class MyCommand
        {
            public string NewValue { get; set; }
        }

        public class MyCommandHandler : ICommandHandler<MyCommand>
        {
            private readonly Action<string> _setter;

            public MyCommandHandler(Action<string> setter)
            {
                _setter = setter;
            }

            public void Handle(MyCommand command)
            {
                _setter.Invoke(command.NewValue);
            }
        }

        protected override void Given()
        {
            _command = new MyCommand() {NewValue = "George"};
            _handler = new MyCommandHandler((s) => _value = s);

            _fac = MockRepository.GenerateStub<IGenericCommandHandlerFactory>();
            _fac.Stub(c => c.GetCommandHandlerInfos<MyCommand>()).Return(new List<ICommandHandlerInfo>
                {new CommandHandlerInfo<MyCommand>(new Lazy<ICommandHandler<MyCommand>>(() => _handler))});
            
            _adapter = new ReflectionGenericCommandHandlerAdapter(_fac);

        }

        protected override void When()
        {
            _hanlderInfos = _adapter.GetCommandHandlerInfos(_command.GetType());
            
        }

        [Then]
        public void new_value_should_be_george()
        {
            _hanlderInfos.Single().Handle(_command); 
            _value.Should().Be("George");
        }

        [Then]
        public void there_should_be_a_handler()
        {
            _hanlderInfos.Count().Should().Be(1);
        }
    }
}