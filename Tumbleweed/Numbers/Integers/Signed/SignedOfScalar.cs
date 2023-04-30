using Tumbleweed.Booleans;
using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Integers.Signed;

public sealed class SignedOfScalar : ISigned
{
	public SignedOfScalar(IScalar<ISigned> scalar) =>
		this.scalar = scalar;

	public IBoolean IsPositive => scalar.Value.IsPositive;

	public INatural Natural => scalar.Value.Natural;

	private readonly IScalar<ISigned> scalar;
}