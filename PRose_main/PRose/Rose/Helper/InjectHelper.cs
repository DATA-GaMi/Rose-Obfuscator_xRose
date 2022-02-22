using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace Rose.Helper
{
	// Token: 0x02000073 RID: 115
	public static class InjectHelper
	{
		// Token: 0x06000167 RID: 359 RVA: 0x0001A790 File Offset: 0x00018990
		private static TypeDefUser Clone(TypeDef origin)
		{
			short num = 0;
			TypeDefUser typeDefUser;
			IEnumerator<GenericParam> enumerator;
			for (;;)
			{
				if (num == 5)
				{
					goto IL_1F;
				}
				IL_3A:
				if (num == 3)
				{
					if (origin.ClassLayout == null)
					{
						goto IL_1F;
					}
					num = 4;
				}
				if (num == 1)
				{
					typeDefUser = new TypeDefUser(origin.Namespace, origin.Name);
					num = 2;
				}
				if (num == 2)
				{
					typeDefUser.Attributes = origin.Attributes;
					num = 3;
				}
				if (num == 4)
				{
					typeDefUser.ClassLayout = new ClassLayoutUser(origin.ClassLayout.PackingSize, origin.ClassSize);
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 6)
				{
					break;
				}
				continue;
				IL_1F:
				enumerator = origin.GenericParameters.GetEnumerator();
				num = 6;
				goto IL_3A;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					GenericParam genericParam = enumerator.Current;
					typeDefUser.GenericParameters.Add(new GenericParamUser(genericParam.Number, genericParam.Flags, "-"));
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return typeDefUser;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0001A950 File Offset: 0x00018B50
		private static MethodDefUser Clone(MethodDef origin)
		{
			short num = 0;
			MethodDefUser methodDefUser;
			IEnumerator<GenericParam> enumerator;
			do
			{
				if (num == 1)
				{
					methodDefUser = new MethodDefUser(origin.Name, null, origin.ImplAttributes, origin.Attributes);
					num = 2;
				}
				if (num == 2)
				{
					enumerator = origin.GenericParameters.GetEnumerator();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
			try
			{
				while (enumerator.MoveNext())
				{
					GenericParam genericParam = enumerator.Current;
					methodDefUser.GenericParameters.Add(new GenericParamUser(genericParam.Number, genericParam.Flags, "-"));
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return methodDefUser;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001AA88 File Offset: 0x00018C88
		private static FieldDefUser Clone(FieldDef origin)
		{
			short num = 0;
			FieldDefUser result;
			do
			{
				if (num == 1)
				{
					result = new FieldDefUser(origin.Name, null, origin.Attributes);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
			return result;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001AB14 File Offset: 0x00018D14
		private static TypeDef PopulateContext(TypeDef typeDef, InjectHelper.InjectContext ctx)
		{
			short num = 0;
			TypeDef typeDef2;
			IEnumerator<TypeDef> enumerator;
			for (;;)
			{
				if (num == 5)
				{
					goto IL_1F;
				}
				IL_35:
				if (num == 4)
				{
					goto IL_BC;
				}
				if (num == 3)
				{
					ctx.Map[typeDef] = typeDef2;
					num = 4;
				}
				if (num == 2)
				{
					typeDef2 = InjectHelper.Clone(typeDef);
					num = 3;
				}
				if (num == 6)
				{
					goto IL_BC;
				}
				IL_D7:
				IDnlibDef dnlibDef;
				if (num == 1)
				{
					if (ctx.Map.TryGetValue(typeDef, out dnlibDef))
					{
						goto IL_1F;
					}
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 7)
				{
					break;
				}
				continue;
				IL_BC:
				enumerator = typeDef.NestedTypes.GetEnumerator();
				num = 7;
				goto IL_D7;
				IL_1F:
				typeDef2 = (TypeDef)dnlibDef;
				num = 6;
				goto IL_35;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					TypeDef typeDef3 = enumerator.Current;
					typeDef2.NestedTypes.Add(InjectHelper.PopulateContext(typeDef3, ctx));
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			foreach (MethodDef methodDef in typeDef.Methods)
			{
				typeDef2.Methods.Add((MethodDef)(ctx.Map[methodDef] = InjectHelper.Clone(methodDef)));
			}
			foreach (FieldDef fieldDef in typeDef.Fields)
			{
				typeDef2.Fields.Add((FieldDef)(ctx.Map[fieldDef] = InjectHelper.Clone(fieldDef)));
			}
			return typeDef2;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0001ADE4 File Offset: 0x00018FE4
		private static void CopyTypeDef(TypeDef typeDef, InjectHelper.InjectContext ctx)
		{
			short num = 0;
			IEnumerator<InterfaceImpl> enumerator;
			TypeDef typeDef2;
			do
			{
				if (num == 3)
				{
					enumerator = typeDef.Interfaces.GetEnumerator();
					num = 4;
				}
				if (num == 2)
				{
					typeDef2.BaseType = (ITypeDefOrRef)ctx.Importer.Import(typeDef.BaseType);
					num = 3;
				}
				if (num == 1)
				{
					typeDef2 = (TypeDef)ctx.Map[typeDef];
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			try
			{
				while (enumerator.MoveNext())
				{
					InterfaceImpl interfaceImpl = enumerator.Current;
					typeDef2.Interfaces.Add(new InterfaceImplUser((ITypeDefOrRef)ctx.Importer.Import(interfaceImpl.Interface)));
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0001AF5C File Offset: 0x0001915C
		private static void CopyMethodDef(MethodDef methodDef, InjectHelper.InjectContext ctx)
		{
			short num = 0;
			MethodDef methodDef2;
			IEnumerator<CustomAttribute> enumerator;
			for (;;)
			{
				if (num == 5)
				{
					methodDef2.ImplMap = new ImplMapUser(new ModuleRefUser(ctx.TargetModule, methodDef.ImplMap.Module.Name), methodDef.ImplMap.Name, methodDef.ImplMap.Attributes);
					num = 6;
				}
				if (num == 1)
				{
					methodDef2 = (MethodDef)ctx.Map[methodDef];
					num = 2;
				}
				if (num == 6)
				{
					goto IL_B9;
				}
				IL_D4:
				if (num == 2)
				{
					methodDef2.Signature = ctx.Importer.Import(methodDef.Signature);
					num = 3;
				}
				if (num == 4)
				{
					if (methodDef.ImplMap == null)
					{
						goto IL_B9;
					}
					num = 5;
				}
				if (num == 3)
				{
					methodDef2.Parameters.UpdateParameterTypes();
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 7)
				{
					break;
				}
				continue;
				IL_B9:
				enumerator = methodDef.CustomAttributes.GetEnumerator();
				num = 7;
				goto IL_D4;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					CustomAttribute customAttribute = enumerator.Current;
					methodDef2.CustomAttributes.Add(new CustomAttribute((ICustomAttributeType)ctx.Importer.Import(customAttribute.Constructor)));
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (methodDef.HasBody)
			{
				methodDef2.Body = new CilBody(methodDef.Body.InitLocals, new List<Instruction>(), new List<ExceptionHandler>(), new List<Local>());
				methodDef2.Body.MaxStack = methodDef.Body.MaxStack;
				Dictionary<object, object> bodyMap = new Dictionary<object, object>();
				foreach (Local local in methodDef.Body.Variables)
				{
					Local local2 = new Local(ctx.Importer.Import(local.Type));
					methodDef2.Body.Variables.Add(local2);
					bodyMap[local] = local2;
				}
				foreach (Instruction instruction in methodDef.Body.Instructions)
				{
					Instruction instruction2 = new Instruction(instruction.OpCode, instruction.Operand);
					if (instruction2.Operand is IType)
					{
						instruction2.Operand = ctx.Importer.Import((IType)instruction2.Operand);
					}
					else if (instruction2.Operand is IMethod)
					{
						instruction2.Operand = ctx.Importer.Import((IMethod)instruction2.Operand);
					}
					else if (instruction2.Operand is IField)
					{
						instruction2.Operand = ctx.Importer.Import((IField)instruction2.Operand);
					}
					methodDef2.Body.Instructions.Add(instruction2);
					bodyMap[instruction] = instruction2;
				}
				Func<Instruction, Instruction> <>9__0;
				foreach (Instruction instruction3 in methodDef2.Body.Instructions)
				{
					if (instruction3.Operand != null && bodyMap.ContainsKey(instruction3.Operand))
					{
						instruction3.Operand = bodyMap[instruction3.Operand];
					}
					else if (instruction3.Operand is Instruction[])
					{
						Instruction instruction4 = instruction3;
						IEnumerable<Instruction> source = (Instruction[])instruction3.Operand;
						Func<Instruction, Instruction> selector;
						if ((selector = <>9__0) == null)
						{
							selector = (<>9__0 = ((Instruction target) => (Instruction)bodyMap[target]));
						}
						instruction4.Operand = source.Select(selector).ToArray<Instruction>();
					}
				}
				foreach (ExceptionHandler exceptionHandler in methodDef.Body.ExceptionHandlers)
				{
					methodDef2.Body.ExceptionHandlers.Add(new ExceptionHandler(exceptionHandler.HandlerType)
					{
						CatchType = ((exceptionHandler.CatchType == null) ? null : ((ITypeDefOrRef)ctx.Importer.Import(exceptionHandler.CatchType))),
						TryStart = (Instruction)bodyMap[exceptionHandler.TryStart],
						TryEnd = (Instruction)bodyMap[exceptionHandler.TryEnd],
						HandlerStart = (Instruction)bodyMap[exceptionHandler.HandlerStart],
						HandlerEnd = (Instruction)bodyMap[exceptionHandler.HandlerEnd],
						FilterStart = ((exceptionHandler.FilterStart == null) ? null : ((Instruction)bodyMap[exceptionHandler.FilterStart]))
					});
				}
				methodDef2.Body.SimplifyMacros(methodDef2.Parameters);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0001B6E8 File Offset: 0x000198E8
		private static void CopyFieldDef(FieldDef fieldDef, InjectHelper.InjectContext ctx)
		{
			short num = 0;
			do
			{
				if (num == 2)
				{
					FieldDef fieldDef2;
					fieldDef2.Signature = ctx.Importer.Import(fieldDef.Signature);
					num = 3;
				}
				if (num == 1)
				{
					FieldDef fieldDef2 = (FieldDef)ctx.Map[fieldDef];
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0001B7B0 File Offset: 0x000199B0
		private static void Copy(TypeDef typeDef, InjectHelper.InjectContext ctx, bool copySelf)
		{
			short num = 0;
			IEnumerator<TypeDef> enumerator;
			for (;;)
			{
				if (num != 1)
				{
					goto IL_31;
				}
				if (copySelf)
				{
					num = 2;
					goto IL_31;
				}
				goto IL_42;
				IL_5D:
				if (num == 2)
				{
					InjectHelper.CopyTypeDef(typeDef, ctx);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 4)
				{
					break;
				}
				continue;
				IL_31:
				if (num != 3)
				{
					goto IL_5D;
				}
				IL_42:
				enumerator = typeDef.NestedTypes.GetEnumerator();
				num = 4;
				goto IL_5D;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					TypeDef typeDef2 = enumerator.Current;
					InjectHelper.Copy(typeDef2, ctx, true);
				}
			}
			finally
			{
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			foreach (MethodDef methodDef in typeDef.Methods)
			{
				InjectHelper.CopyMethodDef(methodDef, ctx);
			}
			foreach (FieldDef fieldDef in typeDef.Fields)
			{
				InjectHelper.CopyFieldDef(fieldDef, ctx);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0001B998 File Offset: 0x00019B98
		public static TypeDef Inject(TypeDef typeDef, ModuleDef target)
		{
			short num = 0;
			InjectHelper.InjectContext injectContext;
			do
			{
				if (num == 3)
				{
					InjectHelper.Copy(typeDef, injectContext, true);
					num = 4;
				}
				if (num == 1)
				{
					injectContext = new InjectHelper.InjectContext(typeDef.Module, target);
					num = 2;
				}
				if (num == 2)
				{
					InjectHelper.PopulateContext(typeDef, injectContext);
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			return (TypeDef)injectContext.Map[typeDef];
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0001BA84 File Offset: 0x00019C84
		public static MethodDef Inject(MethodDef methodDef, ModuleDef target)
		{
			short num = 0;
			InjectHelper.InjectContext injectContext;
			do
			{
				if (num == 2)
				{
					injectContext.Map[methodDef] = InjectHelper.Clone(methodDef);
					num = 3;
				}
				if (num == 1)
				{
					injectContext = new InjectHelper.InjectContext(methodDef.Module, target);
					num = 2;
				}
				if (num == 3)
				{
					InjectHelper.CopyMethodDef(methodDef, injectContext);
					num = 4;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 4);
			return (MethodDef)injectContext.Map[methodDef];
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001BB78 File Offset: 0x00019D78
		public static IEnumerable<IDnlibDef> Inject(TypeDef typeDef, TypeDef newType, ModuleDef target)
		{
			short num = 0;
			InjectHelper.InjectContext injectContext;
			do
			{
				if (num == 4)
				{
					InjectHelper.Copy(typeDef, injectContext, false);
					num = 5;
				}
				if (num == 1)
				{
					injectContext = new InjectHelper.InjectContext(typeDef.Module, target);
					num = 2;
				}
				if (num == 3)
				{
					InjectHelper.PopulateContext(typeDef, injectContext);
					num = 4;
				}
				if (num == 2)
				{
					injectContext.Map[typeDef] = newType;
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 5);
			return injectContext.Map.Values.Except(new TypeDef[]
			{
				newType
			});
		}

		// Token: 0x02000074 RID: 116
		private class InjectContext : ImportResolver
		{
			// Token: 0x06000172 RID: 370 RVA: 0x000025B4 File Offset: 0x000007B4
			public InjectContext(ModuleDef module, ModuleDef target)
			{
				this.OriginModule = module;
				this.TargetModule = target;
				this.importer = new Importer(target, ImporterOptions.TryToUseTypeDefs);
				this.importer.Resolver = this;
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000173 RID: 371 RVA: 0x000025EE File Offset: 0x000007EE
			public Importer Importer
			{
				get
				{
					return this.importer;
				}
			}

			// Token: 0x06000174 RID: 372 RVA: 0x000025F6 File Offset: 0x000007F6
			public override TypeDef Resolve(TypeDef typeDef)
			{
				if (this.Map.ContainsKey(typeDef))
				{
					return (TypeDef)this.Map[typeDef];
				}
				return null;
			}

			// Token: 0x06000175 RID: 373 RVA: 0x00002619 File Offset: 0x00000819
			public override MethodDef Resolve(MethodDef methodDef)
			{
				if (this.Map.ContainsKey(methodDef))
				{
					return (MethodDef)this.Map[methodDef];
				}
				return null;
			}

			// Token: 0x06000176 RID: 374 RVA: 0x0000263C File Offset: 0x0000083C
			public override FieldDef Resolve(FieldDef fieldDef)
			{
				if (this.Map.ContainsKey(fieldDef))
				{
					return (FieldDef)this.Map[fieldDef];
				}
				return null;
			}

			// Token: 0x04000081 RID: 129
			public readonly Dictionary<IDnlibDef, IDnlibDef> Map = new Dictionary<IDnlibDef, IDnlibDef>();

			// Token: 0x04000082 RID: 130
			public readonly ModuleDef OriginModule;

			// Token: 0x04000083 RID: 131
			public readonly ModuleDef TargetModule;

			// Token: 0x04000084 RID: 132
			private readonly Importer importer;
		}
	}
}
