namespace Tumbleweed.Scalars;

public abstract class ScalarEnvelope<T> : IScalar<T>
{
	protected ScalarEnvelope(Func<T> @delegate) : this
	(
		new ScalarOfDelegate<T>(@delegate)
	)
	{
	}
	
	protected ScalarEnvelope(IScalar<T> scalar)
	{
		this.scalar = scalar;
	}
	
	public T Value()
	{
		return scalar.Value();
	}

	private readonly IScalar<T> scalar;
}