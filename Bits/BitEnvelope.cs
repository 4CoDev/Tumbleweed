using Tumbleweed.Scalars;

namespace Tumbleweed.Bits;

public abstract class BitEnvelope : IBit
{
	protected BitEnvelope(IBit bit)
	{
		this.bit = bit;
	}

	public IScalar<bool> State
	{
		get => bit.State;
	}
	
	private readonly IBit bit;
}