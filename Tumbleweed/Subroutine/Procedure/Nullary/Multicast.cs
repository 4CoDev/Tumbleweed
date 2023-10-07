using Tumbleweed.Enumerable;

namespace Tumbleweed.Subroutine.Procedure.Nullary;

public sealed class Multicast : Nullary.Envelope
{
	public Multicast(params Nullary.Any[] procedures) : this
	(
		new Concatenated<Any>(procedures)
	)
	{
	}
	
	public Multicast(IEnumerable<Nullary.Any> actions) : base
	(
		new From.System(
			() => Result(actions))
	)
	{
	}
	
	private static void Result(IEnumerable<Nullary.Any> procedures)
	{
		foreach (Nullary.Any procedure in procedures)
			procedure.Invoke();
	}
}