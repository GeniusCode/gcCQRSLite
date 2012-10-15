using System.Linq;
using System;

namespace GeniusCode.Cqrs.Persistance
{
	//http://abdullin.com/journal/2011/1/19/scalable-and-simple-cqrs-views-in-the-cloud.html
	public interface IViewWriter<TKey, TView> where TView : IViewEntity<TKey>
	{
		void AddOrUpdate(TKey key, Func<TView> addFactory, Action<TView> update);
		void AddOrUpdate(TKey key, TView newView, Action<TView> update);
		void UpdateOrThrow(TKey key, Action<TView> change);
		bool TryUpdate(TKey key, Action<TView> change);
		void Delete(TKey key);
	}
}

