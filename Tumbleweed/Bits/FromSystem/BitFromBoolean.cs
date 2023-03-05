using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromSystem;

public sealed class BitFromBoolean : IBit
{
	public BitFromBoolean(bool boolean) : this
	(
		new ScalarOfValue<bool>(boolean)
	)
	{
	}
	
	public BitFromBoolean(IScalar<bool> boolean)
	{
		this.boolean = boolean;
	}

	public bool State => boolean.Value;

	private readonly IScalar<bool> boolean;
}