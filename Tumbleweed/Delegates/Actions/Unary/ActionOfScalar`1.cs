using Tumbleweed.Scalars;

namespace Tumbleweed.Delegates.Actions.Unary;

public sealed class ActionOfScalar<T> : IUnaryAction<T>
{
	public ActionOfScalar
	(
		IScalar<IUnaryAction<T>> scalar
	)
	{
		this.scalar = scalar;
	}
	
	public void Invoke(T parameter) =>
		scalar.Value.Invoke(parameter);
	
	private readonly IScalar<IUnaryAction<T>> scalar;
}