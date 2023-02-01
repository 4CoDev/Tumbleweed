using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace TumbleSystem.Bits.FromEnumerable;

public sealed class BitAtIndex : BitEnvelope
{
	public BitAtIndex(IEnumerable<IBit> bits, int index) : this
	(
		new List<IBit>(bits), new ScalarOfValue<int>(index)
	)
	{
	}
	
	public BitAtIndex(IEnumerable<IBit> bits, IScalar<int> index) : this
	(
		new List<IBit>(bits), index
	)
	{
	}
	
	public BitAtIndex(ICollection<IBit> bits, int index) : this
	(
		bits, new ScalarOfValue<int>(index)
	)
	{
	}
	
	public BitAtIndex(ICollection<IBit> bits, IScalar<int> index) : base
	(
		new BitOfDelegate(
			() => bits.ElementAt(index.Value()))
	)
	{
	}
}