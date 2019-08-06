// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MakeHypar
{
	public class MakeHyparInputs: S3Args
	{
		/// <summary>
		/// The amplitude in the x direction.
		/// </summary>
		[JsonProperty("X Amplitude")]
		public double XAmplitude {get;}

		/// <summary>
		/// The amplitude in the y direction.
		/// </summary>
		[JsonProperty("Y Amplitude")]
		public double YAmplitude {get;}

		/// <summary>
		/// The number of panel divisions.
		/// </summary>
		[JsonProperty("Divisions")]
		public double Divisions {get;}


		
		/// <summary>
		/// Construct a MakeHyparInputs with default inputs.
		/// This should be used only for testing.
		/// </summary>
		public MakeHyparInputs() : base()
		{
			this.XAmplitude = 10;
			this.YAmplitude = 10;
			this.Divisions = 20;

		}
		
		/// <summary>
		/// Construct a MakeHyparInputs specifying all inputs.
		/// </summary>
		/// <returns></returns>
		[JsonConstructor]
		public MakeHyparInputs(double xamplitude, double yamplitude, double divisions, string bucketName, string uploadsBucket, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, gltfKey, elementsKey, ifcKey)
		{
			this.XAmplitude = xamplitude;
			this.YAmplitude = yamplitude;
			this.Divisions = divisions;

		}
	}
}