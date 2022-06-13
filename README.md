# LINQ (Language Integrated Query)

**-LINQ .Net Framework 3.5 ve Visual Studio 2008 ile hayatımıza giren farklı data source yani veri 
kaynaklarını sorgulamamıza yarayan bir dildir. LINQ Visual Basic ve C# ile birlikte kullanılabilir.**
<br><br>
EF Core ile yarattığımız context'in elemanları yani tabloların koddaki karşıklıkları DBSet tipindedir.
Dolayısıyla LINQ kullanılarak DBSet'ler üzerinde sorgulama yapılabilir.

#### Projede Kullanılan  Metotlar 
<ul>
  <li> Find() </li>
  <li> FirstOrDefault()</li>
  <li>  SingleOrDefault()</li>
  <li>  ToList()</li>
  <li> Count() </li>
  <li>OrderBy/OrderByDescending() </li>
  <li>Any </li>
  <li>Anonymous Object Result </li>
</ul>

<hr>

**<li> Find() </li>**

DBSet sınıfı ile kullanılabilen bir metottur. İlgili DbSet üzerinden Primary Key olarak tanımlanan alana göre arama yapmak için kullanılır.<br>
<br>

**<li>First/FirstOrDefault()</li>**

First ve FirstOrDefault birden fazla verinin olabileceği sorgulamaların sonunda listedeki ilk elemanı seçmek için kullanılır.
<br>
:red_circle:***Önemli:<br>
First() ve FirstOrDefault() arasındaki temel fark; eğer listede veri bulunamazsa First() hata fırlatırken, FirstOrDefault() geriye null döndürür.
Bu nedenle FirstOrDefault() ile veriyi çekip daha sonradan verinin null olup olmadığını kontrol etmek daha doğru bir yaklaşım olur.***
<br>
<br>
**<li>  SingleOrDefault()</li>**
Sorgulama sonunda kalan tek veriyi geri döndürür. Eğer listede birden fazla eleman varsa hata döndürür. Listede hiç eleman yoksa geriye null döndürür.<br>
<br>
<br>
**<li>  ToList()</li>** 
Sorgulama sonucunu geriye koleksiyon olarak döndürmek için kullanılır.<br>
<br><br>
**<li>OrderBy/OrderByDescending() </li>**
OrderBy() bir listeyi sıralamak için kullanılır. OrderBy() varsayılan olarak Ascending sıralama sunar. Tersi sıralamak için OrderByDescending() kullanılmalıdır. <br>

<br>

***<li>Anonymous Object Result </li>***
LINQ her zaman geriye entity objesi dönmek zorunda değildir. Query sonucunu kendi yarattığınız bir obje formatında döndürebilirsiniz.


<br><br>


[Daha fazla bilgi edinmek için](https://www.entityframeworktutorial.net/querying-entity-graph-in-entity-framework.aspx)
:trollface:


















