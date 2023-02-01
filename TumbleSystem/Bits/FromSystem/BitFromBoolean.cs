using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace TumbleSystem.Bits.FromSystem;

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

	public bool State
	{
		get => boolean.Value();
	}

	private readonly IScalar<bool> boolean;
}