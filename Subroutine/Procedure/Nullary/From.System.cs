// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Procedure.Nullary.From;

public class System : Nullary.Any
{
	public System(Action procedure) =>
		this.procedure = procedure;

	public void Invoke() => procedure();

	private readonly Action procedure;
}