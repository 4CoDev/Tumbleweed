// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Procedure.Binary.From;

public class System<T1, T2> : Binary.Any<T1, T2>
{
	public System(Action<T1, T2> procedure) =>
		this.procedure = procedure;

	public void InvokeWith(T1 first, T2 second) =>
		procedure(first, second);

	private readonly Action<T1, T2> procedure;
}