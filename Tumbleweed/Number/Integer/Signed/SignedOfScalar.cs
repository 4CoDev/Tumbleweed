using Tumbleweed._Boolean;
using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Integer.Signed;

public sealed class SignedOfScalar : ISigned
{
	public SignedOfScalar(IScalar<ISigned> scalar) =>
		this.scalar = scalar;

	public IBoolean IsPositive => scalar.Value.IsPositive;

	public INatural Natural => scalar.Value.Natural;

	private readonly IScalar<ISigned> scalar;
}