﻿using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Iphone X",
                    Description = @"Eiiitaaa Mainhaaa!! Esse Lorem ipsum é só na sacanageeem!! E que abundância meu irmão viuu!! Assim você vai matar o papai. Só digo uma coisa, Domingo ela não vai! Danadaa!! Vem minha odalisca, agora faz essa cobra coral subir!!! Pau que nasce torto, Nunca se endireita. Tchannn!! Tchannn!! Tu du du pááá! Eu gostchu muitchu, heinn! danadinha! Mainhaa! Agora use meu lorem ipsum ordinária!!! Olha o quibeee! rema, rema, ordinária!.
                                Você usa o Lorem Ipsum tradicional? Sabe de nada inocente!! Conheça meu lorem que é Tchan, Tchan, Tchannn!! Txu Txu Tu Paaaaa!! Vem, vem ordinária!! Venha provar do meu dendê que você não vai se arrepender. Só na sacanageeem!! Eu gostchu muitchu, heinn! Eitchaaa template cheio de abundância danadaaa!! Assim você mata o papai hein!? Etâaaa Mainhaaaaa...me abusa nesse seu layout, me gera, me geraaaa ordinária!!! Só na sacanagem!!!! Venha provar do meu dendê Tu du du pááá!.
                                Mas que abundância meu irmãooo!!! Esse é seu Layout danadaaa!??? Sabe de nada inocente!! Vem, vem, vem ordinária, provar do meu dendê!! Eu gostxuu muitxuu desse seu Layout!! Etâ danadaaaa!! Tá tão lindo que vou falar em inglês só pra você mainhaaa!! Know nothing innocent. Ordinary!! Txhann Txhann, Txu txu tu paaa!! Damned. Only in Slutty!! Abundance that my borther!! Tchan, Tchan, Tchan...Tu tu tu pa!!!!  .
                                Chama, Chama, Chama ordinária!!!! Tu du du pááá! rema, rema, ordinária! olha o quibe! eu gostchu muitchu, heinn! ordinária!! Domingo ela não vai. Tchannn!! Tchannn!! danadinha! Mainhaa! Eiiitaaa Mainhaaa!! Assim você mata o papai , viuu!! Danadaa!! Vem, vem ordinária!! Ahh mainhaa!! venha provar do meu dendê. Só na sacanageeem!! Sabe de nada inocente! que abundânciaaaa meu irmão!! Pau que nasce torto, Nunca se endireita....
                                Vem minha odalisca, agora faz essa cobra coral subir!!! que abundânciaaaa meu irmão!! Sabe de nada inocente! Só na sacanageeem!! venha provar do meu dendê. Ahh mainhaa!! Vem, vem ordinária!! Danadaa!! Assim você mata o papai , viuu!! Eiiitaaa Mainhaaa!! danadinha! Mainhaa! Tchannn!! Tchannn!! Domingo ela não vai. Sunday she won't go!! ordinária!! eu gostchu muitchu, heinn! olha o quibe! rema, rema, ordinária! Tu du du pááá!.
                                Agora sim Mainhaaa!!! Me preencha nesse seu layout danadaaa!! Etâaaa mainhaaa!! danadaaa! Tu tu tu paa!!! Mas que abundância meu irmãooo!!! Esse é seu Layout danadaaa!??? Sabe de nada inocente!! Vem, vem, vem ordinária, provar do meu dendê!! Eu gostxuu muitxuu desse seu Layout!! Assim você mata o papai , viuu!! Eiiitaaa Mainhaaa!! danadinha! Mainhaa! Tchannn!! Tchannn!! Domingo ela não vai. Sunday she won't go!! ordinária!! .",
                    Price = 8000.00M,
                    Image = "product-1.png",
                    Category = "Smartphone"
                },
                {
                    new Product()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Iphone 12",
                        Description = @"Eiiitaaa Mainhaaa!! Esse Lorem ipsum é só na sacanageeem!! E que abundância meu irmão viuu!! Assim você vai matar o papai. Só digo uma coisa, Domingo ela não vai! Danadaa!! Vem minha odalisca, agora faz essa cobra coral subir!!! Pau que nasce torto, Nunca se endireita. Tchannn!! Tchannn!! Tu du du pááá! Eu gostchu muitchu, heinn! danadinha! Mainhaa! Agora use meu lorem ipsum ordinária!!! Olha o quibeee! rema, rema, ordinária!.
                                Você usa o Lorem Ipsum tradicional? Sabe de nada inocente!! Conheça meu lorem que é Tchan, Tchan, Tchannn!! Txu Txu Tu Paaaaa!! Vem, vem ordinária!! Venha provar do meu dendê que você não vai se arrepender. Só na sacanageeem!! Eu gostchu muitchu, heinn! Eitchaaa template cheio de abundância danadaaa!! Assim você mata o papai hein!? Etâaaa Mainhaaaaa...me abusa nesse seu layout, me gera, me geraaaa ordinária!!! Só na sacanagem!!!! Venha provar do meu dendê Tu du du pááá!.
                                Mas que abundância meu irmãooo!!! Esse é seu Layout danadaaa!??? Sabe de nada inocente!! Vem, vem, vem ordinária, provar do meu dendê!! Eu gostxuu muitxuu desse seu Layout!! Etâ danadaaaa!! Tá tão lindo que vou falar em inglês só pra você mainhaaa!! Know nothing innocent. Ordinary!! Txhann Txhann, Txu txu tu paaa!! Damned. Only in Slutty!! Abundance that my borther!! Tchan, Tchan, Tchan...Tu tu tu pa!!!!  .
                                Chama, Chama, Chama ordinária!!!! Tu du du pááá! rema, rema, ordinária! olha o quibe! eu gostchu muitchu, heinn! ordinária!! Domingo ela não vai. Tchannn!! Tchannn!! danadinha! Mainhaa! Eiiitaaa Mainhaaa!! Assim você mata o papai , viuu!! Danadaa!! Vem, vem ordinária!! Ahh mainhaa!! venha provar do meu dendê. Só na sacanageeem!! Sabe de nada inocente! que abundânciaaaa meu irmão!! Pau que nasce torto, Nunca se endireita....
                                Vem minha odalisca, agora faz essa cobra coral subir!!! que abundânciaaaa meu irmão!! Sabe de nada inocente! Só na sacanageeem!! venha provar do meu dendê. Ahh mainhaa!! Vem, vem ordinária!! Danadaa!! Assim você mata o papai , viuu!! Eiiitaaa Mainhaaa!! danadinha! Mainhaa! Tchannn!! Tchannn!! Domingo ela não vai. Sunday she won't go!! ordinária!! eu gostchu muitchu, heinn! olha o quibe! rema, rema, ordinária! Tu du du pááá!.
                                Agora sim Mainhaaa!!! Me preencha nesse seu layout danadaaa!! Etâaaa mainhaaa!! danadaaa! Tu tu tu paa!!! Mas que abundância meu irmãooo!!! Esse é seu Layout danadaaa!??? Sabe de nada inocente!! Vem, vem, vem ordinária, provar do meu dendê!! Eu gostxuu muitxuu desse seu Layout!! Assim você mata o papai , viuu!! Eiiitaaa Mainhaaa!! danadinha! Mainhaa! Tchannn!! Tchannn!! Domingo ela não vai. Sunday she won't go!! ordinária!! .",
                        Price = 18000.00M,
                        Image = "product-2.png",
                        Category = "Smartphone"
                    }
                },
                {
                    new Product()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Xiaomi 10",
                        Description = @"Eiiitaaa Mainhaaa!! Esse Lorem ipsum é só na sacanageeem!! E que abundância meu irmão viuu!! Assim você vai matar o papai. Só digo uma coisa, Domingo ela não vai! Danadaa!! Vem minha odalisca, agora faz essa cobra coral subir!!! Pau que nasce torto, Nunca se endireita. Tchannn!! Tchannn!! Tu du du pááá! Eu gostchu muitchu, heinn! danadinha! Mainhaa! Agora use meu lorem ipsum ordinária!!! Olha o quibeee! rema, rema, ordinária!.
                                Você usa o Lorem Ipsum tradicional? Sabe de nada inocente!! Conheça meu lorem que é Tchan, Tchan, Tchannn!! Txu Txu Tu Paaaaa!! Vem, vem ordinária!! Venha provar do meu dendê que você não vai se arrepender. Só na sacanageeem!! Eu gostchu muitchu, heinn! Eitchaaa template cheio de abundância danadaaa!! Assim você mata o papai hein!? Etâaaa Mainhaaaaa...me abusa nesse seu layout, me gera, me geraaaa ordinária!!! Só na sacanagem!!!! Venha provar do meu dendê Tu du du pááá!.
                                Mas que abundância meu irmãooo!!! Esse é seu Layout danadaaa!??? Sabe de nada inocente!! Vem, vem, vem ordinária, provar do meu dendê!! Eu gostxuu muitxuu desse seu Layout!! Etâ danadaaaa!! Tá tão lindo que vou falar em inglês só pra você mainhaaa!! Know nothing innocent. Ordinary!! Txhann Txhann, Txu txu tu paaa!! Damned. Only in Slutty!! Abundance that my borther!! Tchan, Tchan, Tchan...Tu tu tu pa!!!!  .
                                Chama, Chama, Chama ordinária!!!! Tu du du pááá! rema, rema, ordinária! olha o quibe! eu gostchu muitchu, heinn! ordinária!! Domingo ela não vai. Tchannn!! Tchannn!! danadinha! Mainhaa! Eiiitaaa Mainhaaa!! Assim você mata o papai , viuu!! Danadaa!! Vem, vem ordinária!! Ahh mainhaa!! venha provar do meu dendê. Só na sacanageeem!! Sabe de nada inocente! que abundânciaaaa meu irmão!! Pau que nasce torto, Nunca se endireita....
                                Vem minha odalisca, agora faz essa cobra coral subir!!! que abundânciaaaa meu irmão!! Sabe de nada inocente! Só na sacanageeem!! venha provar do meu dendê. Ahh mainhaa!! Vem, vem ordinária!! Danadaa!! Assim você mata o papai , viuu!! Eiiitaaa Mainhaaa!! danadinha! Mainhaa! Tchannn!! Tchannn!! Domingo ela não vai. Sunday she won't go!! ordinária!! eu gostchu muitchu, heinn! olha o quibe! rema, rema, ordinária! Tu du du pááá!.
                                Agora sim Mainhaaa!!! Me preencha nesse seu layout danadaaa!! Etâaaa mainhaaa!! danadaaa! Tu tu tu paa!!! Mas que abundância meu irmãooo!!! Esse é seu Layout danadaaa!??? Sabe de nada inocente!! Vem, vem, vem ordinária, provar do meu dendê!! Eu gostxuu muitxuu desse seu Layout!! Assim você mata o papai , viuu!! Eiiitaaa Mainhaaa!! danadinha! Mainhaa! Tchannn!! Tchannn!! Domingo ela não vai. Sunday she won't go!! ordinária!! .",
                        Price = 3000.00M,
                        Image = "product-3.png",
                        Category = "Smartphone"
                    }
                },
                {
                    new Product()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Mate 4",
                        Description = @"Eiiitaaa Mainhaaa!! Esse Lorem ipsum é só na sacanageeem!! E que abundância meu irmão viuu!! Assim você vai matar o papai. Só digo uma coisa, Domingo ela não vai! Danadaa!! Vem minha odalisca, agora faz essa cobra coral subir!!! Pau que nasce torto, Nunca se endireita. Tchannn!! Tchannn!! Tu du du pááá! Eu gostchu muitchu, heinn! danadinha! Mainhaa! Agora use meu lorem ipsum ordinária!!! Olha o quibeee! rema, rema, ordinária!.
                                Você usa o Lorem Ipsum tradicional? Sabe de nada inocente!! Conheça meu lorem que é Tchan, Tchan, Tchannn!! Txu Txu Tu Paaaaa!! Vem, vem ordinária!! Venha provar do meu dendê que você não vai se arrepender. Só na sacanageeem!! Eu gostchu muitchu, heinn! Eitchaaa template cheio de abundância danadaaa!! Assim você mata o papai hein!? Etâaaa Mainhaaaaa...me abusa nesse seu layout, me gera, me geraaaa ordinária!!! Só na sacanagem!!!! Venha provar do meu dendê Tu du du pááá!.
                                Mas que abundância meu irmãooo!!! Esse é seu Layout danadaaa!??? Sabe de nada inocente!! Vem, vem, vem ordinária, provar do meu dendê!! Eu gostxuu muitxuu desse seu Layout!! Etâ danadaaaa!! Tá tão lindo que vou falar em inglês só pra você mainhaaa!! Know nothing innocent. Ordinary!! Txhann Txhann, Txu txu tu paaa!! Damned. Only in Slutty!! Abundance that my borther!! Tchan, Tchan, Tchan...Tu tu tu pa!!!!  .
                                Chama, Chama, Chama ordinária!!!! Tu du du pááá! rema, rema, ordinária! olha o quibe! eu gostchu muitchu, heinn! ordinária!! Domingo ela não vai. Tchannn!! Tchannn!! danadinha! Mainhaa! Eiiitaaa Mainhaaa!! Assim você mata o papai , viuu!! Danadaa!! Vem, vem ordinária!! Ahh mainhaa!! venha provar do meu dendê. Só na sacanageeem!! Sabe de nada inocente! que abundânciaaaa meu irmão!! Pau que nasce torto, Nunca se endireita....
                                Vem minha odalisca, agora faz essa cobra coral subir!!! que abundânciaaaa meu irmão!! Sabe de nada inocente! Só na sacanageeem!! venha provar do meu dendê. Ahh mainhaa!! Vem, vem ordinária!! Danadaa!! Assim você mata o papai , viuu!! Eiiitaaa Mainhaaa!! danadinha! Mainhaa! Tchannn!! Tchannn!! Domingo ela não vai. Sunday she won't go!! ordinária!! eu gostchu muitchu, heinn! olha o quibe! rema, rema, ordinária! Tu du du pááá!.
                                Agora sim Mainhaaa!!! Me preencha nesse seu layout danadaaa!! Etâaaa mainhaaa!! danadaaa! Tu tu tu paa!!! Mas que abundância meu irmãooo!!! Esse é seu Layout danadaaa!??? Sabe de nada inocente!! Vem, vem, vem ordinária, provar do meu dendê!! Eu gostxuu muitxuu desse seu Layout!! Assim você mata o papai , viuu!! Eiiitaaa Mainhaaa!! danadinha! Mainhaa! Tchannn!! Tchannn!! Domingo ela não vai. Sunday she won't go!! ordinária!! .",
                        Price = 18000.00M,
                        Image = "product-4.png",
                        Category = "Smartphone"
                    }
                }
            };
        }
    }
}