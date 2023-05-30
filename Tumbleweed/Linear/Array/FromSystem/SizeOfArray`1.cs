using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.FromSystem;
using Tumbleweed.Scalar;

namespace Tumbleweed.Linear.Array.FromSystem;

public sealed class SizeOfArray<T> : NaturalEnvelope
{
	public SizeOfArray(IScalar<T[]> array) : base
	(
		new NaturalFromInt32(
			new OfSystem.SizeOfArray<T>(array))
	)
	{
	}
}