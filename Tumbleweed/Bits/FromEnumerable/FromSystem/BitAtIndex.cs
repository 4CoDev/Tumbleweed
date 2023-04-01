using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromEnumerable.FromSystem;

public sealed class BitAtIndex : BitEnvelope
{
	public BitAtIndex(IEnumerable<IBit> bits, Int32 index) : this
	(
		new List<IBit>(bits), new ScalarValue<Int32>(index)
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
		bits, new ScalarValue<Int32>(index)
	)
	{
	}
	
	public BitAtIndex(ICollection<IBit> bits, IScalar<Int32> index) : base
	(
		new BitOfFunction(
			() => bits.ElementAt(index.Value))
	)
	{
	}
}