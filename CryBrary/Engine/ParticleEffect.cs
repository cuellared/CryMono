﻿using System;
using System.Runtime.CompilerServices;
using CryEngine.Native;

namespace CryEngine
{
	public class ParticleEffect
	{
        private static INativeParticleEffectMethods _nativeParticleEffectMethods;
        internal static INativeParticleEffectMethods NativeParticleEffectMethods
        {
            get { return _nativeParticleEffectMethods ?? (_nativeParticleEffectMethods = new NativeParticleEffectMethods()); }
            set { _nativeParticleEffectMethods = value; }
        }


		/// <summary>
		/// </summary>
		/// <param name="effectName"></param>
		/// <param name="loadResources">Load all required resources?</param>
		/// <returns></returns>
		public static ParticleEffect Get(string effectName, bool loadResources = true)
		{
            var ptr = NativeParticleEffectMethods.FindEffect(effectName, loadResources);
			if(ptr != IntPtr.Zero)
				return new ParticleEffect(ptr);

			return null;
		}

		internal ParticleEffect(IntPtr ptr)
		{
			Pointer = ptr;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="independent"></param>
		/// <param name="pos"></param>
		/// <param name="dir">Is set to Vec3.Up if null</param>
		/// <param name="scale"></param>
		public void Spawn(Vec3 pos, Vec3? dir = null, float scale = 1f, bool independent = true)
		{
            NativeParticleEffectMethods.Spawn(Pointer, independent, pos, dir ?? Vec3.Up, scale);
		}

		internal IntPtr Pointer { get; set; }
	}
}