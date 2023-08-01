using List = Tumbleweed.Event.Listening.List;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Event;

public interface Any<in T>
{
	List::Any<T> Listeners { get; }
	
	void Invoke();
}