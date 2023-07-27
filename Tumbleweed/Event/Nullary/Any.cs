using Tumbleweed.Event.Subscription;
using NullaryProcedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Event.Nullary;

public interface Any
{
	Subscription.Any<NullaryProcedure.Any> Subscription { get; }
	
	void Invoke();
}