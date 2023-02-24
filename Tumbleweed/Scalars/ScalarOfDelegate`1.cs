using Tumbleweed.HashCodes;
using Tumbleweed.Strings;

namespace Tumbleweed.Scalars;

public sealed class ScalarOfDelegate<T> : IScalar<T>
{
	public ScalarOfDelegate(Func<T> @delegate) =>
		this.@delegate = @delegate;
	
	public T Value() =>
		@delegate();

	public override bool Equals(object? @object) =>
		@object is ScalarOfDelegate<T> action &&
		action.@delegate.Equals(@delegate);

	public override int GetHashCode() =>
		new HashCodeOfObject(@delegate).Value();

	public override string? ToString() =>
		new ObjectAsNullableString(@delegate).Value();

	private readonly Func<T> @delegate;
}