namespace Tumbleweed.Mathematics.Number.Real;

public abstract class Envelope : Tumbleweed.Mathematics.Number.Real.Any
{
	protected Envelope(Any real) =>
		this.real = real;

	public Integer.Any Mantissa =>
		real.Mantissa;

	public Integer.Any Base =>
		real.Base;

	public Integer.Any Exponent =>
		real.Exponent;

	private readonly Any real;
}