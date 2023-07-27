namespace Tumbleweed.Number.Real;

public abstract class Envelope : Real.Any
{
	protected Envelope(Real.Any real) =>
		this.real = real;

	public Integer.Any Mantissa =>
		real.Mantissa;

	public Integer.Any Base =>
		real.Base;

	public Integer.Any Exponent =>
		real.Exponent;

	private readonly Real.Any real;
}