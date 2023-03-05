using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromEnumerable.FromSystem;

public sealed class BitAtIndex : BitEnvelope
{
	public BitAtIndex(IEnumerable<IBit> bits, Int32 index) : this
	(
		new List<IBit>(bits), new ScalarOfValue<Int32>(index)
	)
	{
	}
	
	public BitAtIndex(IEnumerable<IBit> bits, IScalar<Int32> index) : this
	(
		new List<IBit>(bits), index
	)
	{
	}
	
	public BitAtIndex(ICollection<IBit> bits, Int32 index) : this
	(
		bits, new ScalarOfValue<Int32>(index)
	)
	{
	}
	
	public BitAtIndex(ICollection<IBit> bits, IScalar<Int32> index) : base
	(
		new BitOfDelegate(
			() => bits.ElementAt(index.Value))
	)
	{
	}
}