// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Procedure.Unary.Of;

public sealed class Scalar<T> : Unary.Any<T>
{
	public Scalar(Scalar.Immutable.Any<Unary.Any<T>> scalar) =>
		this.scalar = scalar;
	
	public void InvokeWith(T parameter) =>
		scalar.Value.InvokeWith(parameter);
	
	private readonly Scalar.Immutable.Any<Unary.Any<T>> scalar;
}