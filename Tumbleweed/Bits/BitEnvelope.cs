using Tumbleweed.Scalars;

namespace Tumbleweed.Bits;

public abstract class BitEnvelope : IBit
{
	protected BitEnvelope(IBit bit)
	{
		this.bit = bit;
	}

	public bool State => bit.State;

	private readonly IBit bit;
}