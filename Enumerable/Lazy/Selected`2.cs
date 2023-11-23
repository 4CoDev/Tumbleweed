using Enumerable = Tumbleweed.Enumerable;
using SCG = System.Collections.Generic;
using System = System;

namespace Tumbleweed.Enumerable.Lazy;

public sealed class Selected<TFrom, TTo> : Enumerable::Envelope<TTo>
{
	public Selected
	(
		SCG::IEnumerable<TFrom> enumerable,
		System::Func<TFrom, TTo> expression
	) : base
	(
		new Enumerable::Lazy.New<TTo>(
			new Enumerable::Selected<TFrom, TTo>(
				enumerable,
				expression))
	)
	{
	}
}