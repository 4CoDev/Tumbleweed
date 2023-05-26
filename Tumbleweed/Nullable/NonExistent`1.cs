using Tumbleweed._Boolean;

namespace Tumbleweed.Nullable;

public sealed class NonExistent<T> : INullable<T> where T : notnull
{
	public T Value =>
		throw new NullReferenceException("That object does not exist");

	public IBoolean Existing => new False();
}