﻿using SavingsManager.Providers;

namespace SavingsManager.Factory
{
    public class SavingsProviderFactory
    {
        public static ISavingsProvider CreateSavingsModelObject(string type)
        {
            switch (type)
            {
                case "Grupo":
                    return new GroupProvider();
                case "Socio":
                    return new SocioProvider();
                case "Plan":
                    return new PlanProvider();
                default:
                    return null;
            }
        }
    }
}