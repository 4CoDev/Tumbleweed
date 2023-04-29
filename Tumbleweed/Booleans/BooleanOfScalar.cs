using Tumbleweed.Scalars;

namespace Tumbleweed.Booleans;

public sealed class BooleanOfScalar : IBoolean
{
	public BooleanOfScalar(IScalar<IBoolean> scalar)
	{
		this.scalar = scalar;
	}
	
	public Boolean State => scalar.Value.State;

	private readonly IScalar<IBoolean> scalar;
}