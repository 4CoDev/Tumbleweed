namespace Tumbleweed.Booleans;

public abstract class BooleanEnvelope : IBoolean
{
	protected BooleanEnvelope(IBoolean boolean)
	{
		this.boolean = boolean;
	}

	public Boolean State => boolean.State;

	private readonly IBoolean boolean;
}