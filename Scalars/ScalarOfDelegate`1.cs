namespace Tumbleweed.Scalars;

public sealed class ScalarOfDelegate<T> : IScalar<T>
{
	public ScalarOfDelegate(Func<T> function)
	{
		this.function = function;
	}
	
	public T Value()
	{
		return function();
	}

	private readonly Func<T> function;
}