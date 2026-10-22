using System;

IImpressora impressoraSimples = new ImpressoraSimples();
IImpressora impressoraCompleta = new Multifuncional();
IDigitalizadora digitalizadora = new Multifuncional();
IFax fax = new Multifuncional();

impressoraSimples.Imprimir("Relatório");
impressoraCompleta.Imprimir("Contrato");
digitalizadora.Digitalizar();
fax.EnviarFax();
