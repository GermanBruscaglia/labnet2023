console.log("Hola Mundo")

const d = document
const $main = d.querySelector("main"),
    $runApi = d.getElementById("run-api")

let pokeAPI = "https://pokeapi.co/api/v2/pokemon/"

async function loadPokemon(url) {
    try {
       
        let res = await fetch(url),
            json = await res.json(),
            $template = ""

        if (!res.ok) throw { status: res.status, statusText: res.statusText }

        for (let i = 0; i < json.results.length; i++) {


            try {
                let res = await fetch(json.results[i].url),
                    pokemon = await res.json()

                if (!res.ok) throw { status: res.status, statusText: res.statusText }

                $template += `
                <figure class="figure">
                <img class="fondo-img" src="${pokemon.sprites.front_default}" alt="${pokemon.name}"></img>
                <figcaption class="name-pokemon">${pokemon.name.toUpperCase()}</figcaption>    
                </figure>
                `
            } catch (err) {
                console.log(err)
                let message = err.statusText || "Ocurrio un error"
                $template += `
                <figure>
                <figcaption>
                    Error ${err.status}: ${message}
                </figcaption>    
                </figure>
                `
            }
            $main.innerHTML = $template
        }
    } catch (err) {
        console.log(err)
        let message = err.statusText || "Ocurrio un error"
        $main.innerHTML = `<p>Error ${err.status}: ${message}</p>`
    }
}

d.addEventListener("click", e => {
    if (e.target == $runApi) {
        loadPokemon(pokeAPI)
    }
   })