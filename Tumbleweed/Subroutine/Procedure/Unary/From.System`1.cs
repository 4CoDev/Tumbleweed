// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Procedure.Unary.From;

public class System<T> : Unary.Any<T>
{
	public System(Action<T> procedure) =>
		this.procedure = procedure;

	public void InvokeWith(T parameter) =>
		procedure(parameter);

	private readonly Action<T> procedure;
}