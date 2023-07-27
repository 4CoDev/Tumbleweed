using Tumbleweed.Enumerable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Procedure.Nullary.Of;

public sealed class Procedures : Nullary.Envelope
{
	public Procedures(params Nullary.Any[] procedures) : this
	(
		new Concatenated<Any>(procedures)
	)
	{
	}
	
	public Procedures(IEnumerable<Nullary.Any> actions) : base
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