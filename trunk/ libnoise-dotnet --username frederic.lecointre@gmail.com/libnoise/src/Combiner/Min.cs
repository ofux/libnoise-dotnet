﻿// This file is part of Libnoise c#.
//
// Libnoise c# is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Libnoise c# is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with Libnoise c#.  If not, see <http://www.gnu.org/licenses/>.
// 
// From the original Jason Bevins's Libnoise (http://libnoise.sourceforge.net)

namespace Graphics.Tools.Noise.Combiner {

	/// <summary>
	/// Noise module that outputs the smaller of the two output values from
	/// two source modules.
	/// </summary>
	public class Min :CombinerModule, IModule3D {

		#region Ctor/Dtor

		public Min()
			: base(){
		}//end Min

		public Min(IModule left, IModule right)
			: base(left, right) {
		}//end Min

		#endregion

		#region IModule3D Members

		/// <summary>
		/// Generates an output value given the coordinates of the specified input value.
		/// </summary>
		/// <param name="x">The input coordinate on the x-axis.</param>
		/// <param name="y">The input coordinate on the y-axis.</param>
		/// <param name="z">The input coordinate on the z-axis.</param>
		/// <returns>The resulting output value.</returns>
		public double GetValue(double x, double y, double z) {
			return System.Math.Min(((IModule3D)_leftModule).GetValue(x, y, z), ((IModule3D)_rightModule).GetValue(x, y, z));
		}//end GetValue

		#endregion

	}//end class

}//end namespace
