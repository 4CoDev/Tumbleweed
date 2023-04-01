using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.FromSystem;

public sealed class BitFromBoolean : IBit
{
	public BitFromBoolean(Boolean boolean) : this
	(
		new ScalarValue<Boolean>(boolean)
	)
	{
	}
	
	public BitFromBoolean(IScalar<Boolean> boolean)
	{
		this.boolean = boolean;
	}

	public Boolean State => boolean.Value;

	private readonly IScalar<Boolean> boolean;
}