// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Of;

public sealed class New<T> : Envelope<T> where T : new()
{
	public New() : base
	(
		new Tumbleweed.Scalar.Of.Value<T>(new T())
	)
	{
	}
}