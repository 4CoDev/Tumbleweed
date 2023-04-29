using Tumbleweed.Scalars;

namespace Tumbleweed.Booleans.FromSystem;

public sealed class BooleanFromSystem : IBoolean
{
	public BooleanFromSystem(Boolean boolean) : this
	(
		new ScalarValue<Boolean>(boolean)
	)
	{
	}
	
	public BooleanFromSystem(IScalar<Boolean> boolean)
	{
		this.boolean = boolean;
	}

	public Boolean State => boolean.Value;

	private readonly IScalar<Boolean> boolean;
}