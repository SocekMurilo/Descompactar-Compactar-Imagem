// Função Compactar e Descompactar Imagem !!

byte[] compact(byte[] originalData)
{ 
int cont = 0;
byte[] lista = new byte[originalData.Length/2];
    
for (int i = 0; i < originalData.Length; i+=2)
{
    originalData[i] = (byte)(originalData[i] >> 4);
    originalData[i] = (byte)(originalData[i] << 4);
    originalData[i+1] = (byte)(originalData[i+1] >> 4);

    lista[cont]= (byte)(originalData[i] | originalData[i+1]);  
    cont++;
}
return lista;
}
byte[] decompact(byte[] compactedData)
{
int cont = 0;
byte v1,v2;
byte[] valores = new byte[compactedData.Length*2];
for (int i = 0; i < compactedData.Length; i+=1){
    v1 = (byte)(compactedData[i] >> 4);
    v1 = (byte)(v1 << 4);
    v2 = (byte)(compactedData[i] << 4);

    valores[cont] = (byte)(v1 | 4);
    cont ++;
    valores[cont] = (byte)(v2 | 4);
    cont ++;
    
}
return valores;
}
