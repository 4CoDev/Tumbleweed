using Tumbleweed.Booleans;

namespace Tumbleweed.Nullables;

public sealed class NonExistent<T> : INullable<T> where T : notnull
{
	public T Value =>
		throw new NullReferenceException("That object does not exist");

	public IBoolean Existing => new False();
}