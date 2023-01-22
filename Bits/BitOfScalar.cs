using Tumbleweed.Scalars;

namespace Tumbleweed.Bits;

public sealed class BitOfScalar : IBit
{
	public BitOfScalar(IScalar<IBit> scalar)
	{
		this.scalar = scalar;
	}
	
	public IScalar<bool> State
	{
		get => scalar.Value().State;
	}

	private readonly IScalar<IBit> scalar;
}