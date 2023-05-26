using Tumbleweed.Number.Integer.Signed;

namespace Tumbleweed.Number.Real;

public abstract class RealEnvelope : IReal
{
	protected RealEnvelope(IReal real) =>
		this.real = real;

	public ISigned Mantissa => real.Mantissa;

	public ISigned Base => real.Base;

	public ISigned Exponent => real.Exponent;

	private readonly IReal real;
}