# Rekrytehtävä

## Suoritus

- Luo uusi repo käyttämällä tätä repoa mallina
- Lataa oma repo koneellesi ja tee tehtävät
- Kommitoi tehdyt muutokset ja puske ne githubiin
- Anna lukuoikeudet repoon `WaldoPas` ja `JeZe97` käyttäjille, jotta pääsemme tutustumaan tuotokseen
- Laita vielä mailia perään, että tehtävä on nyt valmis

## Vaatimukset

- VS Code sopivilla plugareilla(C#, Volar jne), voi käyttää myös muuta editoria/ympäristöä
- .NET SDK 6.x
- Node.js LTS versio

## Setup

- VS code huolehtii launch.json ja tasks.json luonnista
- ClientApp kansiossa suorita `npm ci`

## Komentoriviltä käyttö

- Päähakemistossa `dotnet build rekry.sln`
- Käyntiin komennolla `dotnet run --project rekry/rekry.csproj`
- Siirry sivulle `https://localhost:7033` ja se ohjaa oikeaan paikkaan

- Testit komennolla `dotnet test`
## Huomioitavaa

- Varmista että portit ohjataa oikein järjestelmässäsi ja muuta tarvittaessa
- Apin heittäessä hallitsemattoman poikkeuksen, CORS:a ei hallita oikein(ei tule headeria `Access-Control-Allow-Origin`)

## Sovelluksen rakenne

### Backend muodostuu seuraavista osista:
Rekry
- Controllers, kontrollerit
- Data, sisältää liittymät dataan
- Dto, Data transfer objektit, joita käytetään Api:ssa
- Entity, Datan POCO:t
- Services, Ohjelmalogiikan yksiköt
- `Program.cs` on käynnistyspiste

Tests
- Yksikkötestit tiedossa `InvoiceTests.cs`

### Frontti hakemistossa ClientApp/src:

- components, sisältää sivujen fragmentit
- router, sivujen reititys
- services, tiedon haku apista
- views, näkymät, joihin ohjataan
- types.ts, sisältää käytetyt tyypit

---

## Tehtävälista

1. Sääennusteessa näkyy nyt vain 4 kaupunkia. Korjaa ongelma, jotta saadaan kaikki kaupungit näkyville.
2. Sääennusteen lämpötilat ovat fahrenheittejä, joten niistä ei ole juurikaan apua suurimmalle osalle käyttäjäkuntaa. Muuta nämä celciusasteiksi.
3. Sääennusteen kuvaus ei vastaa lämpötilaa. Muuta kuvaukset vastaamaan lämpötiloja oman harkinnan mukaan
4. Lisää toiminto, joka näyttää jokaisen kaupungin lämpöennätyksen eli useampien tehtyjen hakujen suurimman lämpötilan.
5. Funktio `IsInvoiceOverdue` ei läpäise testiä `DueIsTodayAndInvoiceIsStillOpen`. Korjaa funktion toiminta.
6. Luo julkinen korkolaskumetodi nimeltä `InterestSum`, joka laskee vuosikorkoa eräpäivästä alkaen käyttäen 7% viivästyskorkoa.
   Metodi laskee koron nykyisestä ja/tai input parametrinä annetusta päivästä eteenpäin.
   Vuosikorkoa laskettessa vuoden mitta on 365 päivää. Todista oikea toiminta yksikkötestillä.
7. Tee kontrolleri `InvoicesController` ja siihen

   a) rajapinta, joka palauttaa laskun id:llä

   b) kaikki laskut mahdollisuudella rajata onko lasku maksettu(Sum = 0) ja/tai asiakkaan nimellä

   c) Lisää invoices -kontrolleriin PATCH-metodi, joka maksaa laskun

8. Datakerros on tällä hetkellä käytettynä suoraan(DataContext). Suunnittele/toteuta oma visiosi siitä miten datakerros olisi järkevää abstraktoida. Toisin sanoen, miten eristäisit
   datakerroksen logiikasta. Oikeassa tilanteessa DataContext-luokkaa vastaisi esimerkiksi entity frameworkin DBContext.

Koodia voi ja kannattaa kommentoida merkittäviltä osiltaan.

---

## Palautus

Lisää omaan githubiin repo käyttämällä tätä mallina ja kutsu käyttäjät `WaldoPas` ja `JeZe97` siihen

## Vue ja Viten alkuperäinen ohjeistus

### Vue 3 + Typescript + Vite

This template should help get you started developing with Vue 3 and Typescript in Vite. The template uses Vue 3 `<script setup>` SFCs, check out
the [script setup docs](https://v3.vuejs.org/api/sfc-script-setup.html#sfc-script-setup) to learn more.

### Recommended IDE Setup

- [VSCode](https://code.visualstudio.com/) + [Volar](https://marketplace.visualstudio.com/items?itemName=johnsoncodehk.volar)

### Type Support For `.vue` Imports in TS

Since TypeScript cannot handle type information for `.vue` imports, they are shimmed to be a generic Vue component type by default. In most cases this is fine if you don't really
care about component prop types outside of templates. However, if you wish to get actual prop types in `.vue` imports (for example to get props validation when using
manual `h(...)` calls), you can enable Volar's `.vue` type support plugin by running `Volar: Switch TS Plugin on/off` from VSCode command palette.
