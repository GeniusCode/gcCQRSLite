using System.Linq;
using System;

namespace GeniusCode.Cqrs.Persistance
{

	//http://abdullin.com/journal/2011/1/19/scalable-and-simple-cqrs-views-in-the-cloud.html

	//http://abdullin.com/journal/2011/1/19/scalable-and-simple-cqrs-views-in-the-cloud.html

	//http://abdullin.com/journal/2011/1/19/scalable-and-simple-cqrs-views-in-the-cloud.html
	public interface IViewSingletonWriter<TView> where TView : IViewSingleton
	{      
		void AddOrUpdate(Func<TView> addFactory, Action<TView> updateFactory);
		void Delete();
	}

	//http://abdullin.com/journal/2011/1/19/scalable-and-simple-cqrs-views-in-the-cloud.html

	//http://abdullin.com/journal/2011/1/19/scalable-and-simple-cqrs-views-in-the-cloud.html
	/// <summary>
	/// View entity that has an identity (there can be many views
	/// of this type)
	/// </summary>

	//http://abdullin.com/journal/2011/1/19/scalable-and-simple-cqrs-views-in-the-cloud.html

	//http://abdullin.com/journal/2011/1/19/scalable-and-simple-cqrs-views-in-the-cloud.html
	/// <summary>
	/// View singleton (there can be only one document).
	/// </summary>
	
}
