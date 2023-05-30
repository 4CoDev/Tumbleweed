using Tumbleweed._Enumerable;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Planar.Array.FromSystem;

public sealed class SizeOfArray<T> : EnumerableEnvelope<INatural>
{
	public SizeOfArray(IScalar<T[,]> array) : base
	(
		new NaturalsFromInts32(
			new OfSystem.SizeOfArray<T>(array))
	)
	{
	}
}