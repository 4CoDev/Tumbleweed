using Immutable = Tumbleweed.Scalar.Immutable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Immutable.Of;

public sealed class New<T> : Immutable::Envelope<T> where T : new()
{
	public New() : base
	(
		new Immutable::With.Value<T>(new T())
	)
	{
	}
}