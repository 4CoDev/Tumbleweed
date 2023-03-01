using Tumbleweed.Numerics.Integers.Signed;

namespace Tumbleweed.Numerics.Fractional;

public abstract class FractionalEnvelope : IFractional
{
	protected FractionalEnvelope(IFractional fractional) =>
		this.fractional = fractional;

	public ISignedInteger Mantissa => fractional.Mantissa;

	public ISignedInteger Base => fractional.Base;

	public ISignedInteger Exponent => fractional.Exponent;

	private readonly IFractional fractional;
}