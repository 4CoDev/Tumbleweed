namespace Tumbleweed.Scalars;

public sealed class ScalarOfDoubleScalar<T> : IScalar<T>
{
	public ScalarOfDoubleScalar(IScalar<IScalar<T>> scalar)
	{
		this.scalar = scalar;
	}
	
	public T Value()
	{
		return scalar.Value().Value();
	}
	
	private readonly IScalar<IScalar<T>> scalar;
	
}