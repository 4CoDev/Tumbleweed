using Tumbleweed.Scalars;

namespace Tumbleweed.Subroutines.Actions.Unary;

public sealed class ActionOfScalar<T> : IAction<T>
{
	public ActionOfScalar(IScalar<IAction<T>> scalar) =>
		this.scalar = scalar;
	
	public void InvokeWith(T parameter) =>
		scalar.Value.InvokeWith(parameter);
	
	private readonly IScalar<IAction<T>> scalar;
}