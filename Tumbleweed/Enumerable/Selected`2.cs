using Enumerable = Tumbleweed.Enumerable;
using System = System;

namespace Tumbleweed.Enumerable;

public sealed class Selected<TFrom, TTo> : Enumerable::Envelope<TTo>
{
	public Selected
	(
		System::Collections.Generic.IEnumerable<TFrom> from,
		System::Func<TFrom, TTo> expression
	) : base
	(
		new Enumerable::Function.Result<TTo>(
			() => from.Select(expression))
	)
	{
	}
}