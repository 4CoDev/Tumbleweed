using Tumbleweed.Scalar;

namespace Tumbleweed.Subroutine.Action.Binary;

public sealed class ActionOfScalar<T1, T2> : IAction<T1, T2>
{
	public ActionOfScalar
	(
		IScalar<IAction<T1, T2>> scalar
	)
	{
		this.scalar = scalar;
	}
	
	public void InvokeWith(T1 first, T2 second) =>
		scalar.Value.InvokeWith(first, second);
	
	private readonly IScalar<IAction<T1, T2>> scalar;
}