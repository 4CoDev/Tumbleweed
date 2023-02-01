namespace Tumbleweed.Scalars;

public sealed class ScalarOfDelegate<T> : IScalar<T>
{
	public ScalarOfDelegate(Func<T> @delegate)
	{
		this.@delegate = @delegate;
	}
	
	public T Value()
	{
		return @delegate();
	}

	private readonly Func<T> @delegate;
}