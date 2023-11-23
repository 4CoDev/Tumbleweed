using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace Tumbleweed.Subroutine.Procedure.Nullary;

public sealed class Multicast : Procedure::Envelope
{
	public Multicast(IEnumerable<Procedure::Any> actions) : base
	(
		new From.System(
			() => Result(actions))
	)
	{
	}
	
	private static void Result(IEnumerable<Procedure::Any> procedures)
	{
		foreach (var procedure in procedures)
			procedure.Invoke();
	}
}