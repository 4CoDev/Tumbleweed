using Enumerable = Tumbleweed.Enumerable;
using Natural = Tumbleweed.Number.Natural;
using Scalar = Tumbleweed.Scalar;

namespace Tumbleweed.Array.Dimension.Planar.System.Size;

public sealed class Tumbleweed<T> : Enumerable::Envelope<Natural::Any>
{
	public Tumbleweed(Tumbleweed.Scalar.Immutable.Any<T[,]> array) : base
	(
		new Natural::From.System.Multiple(
			new System<T>(array))
	)
	{
	}
}