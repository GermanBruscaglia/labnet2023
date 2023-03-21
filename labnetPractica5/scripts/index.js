    const ls = localStorage    
    
    let $formNumero = document.getElementById("form-numero"),
        $main = document.querySelector(".main"),
        $btnReplayWinner = document.getElementById("btn-replay-winner"),
        $btnReplayLoser = document.getElementById("btn-replay-loser"),
        $containerWinner = document.querySelector(".container-winner"),
        $containerLoser = document.querySelector(".container-loser"),
        $puntaje = document.getElementById("puntaje"),
        $diferencia = document.getElementById("diferencia"),
        $puntajeLocalStorage = document.getElementById("puntajeLS"),
        $intentosRestantes = document.getElementById("intentos-restantes"),
        $titleGame = document.getElementById("title-game"),
        numeroRandom = (Math.round(Math.random() * 20)),
        contador = 10
    
    const adivinarNumero = () => {

     document.addEventListener("submit", e => {
        let numeroJugador = $formNumero.nameNumero.value
        
        contador -= 1
        
            if(e.target = $formNumero){
                e.preventDefault()
                if(!numeroJugador){
                    $diferencia.classList.remove("visibility-hidden")
                }  

                if(numeroRandom > numeroJugador){
                    $diferencia.innerHTML = "El número para adivinar es mas ALTO"
                    $diferencia.classList.remove("visibility-hidden")
                    $formNumero.reset()
                }else if(numeroRandom < numeroJugador){
                    $diferencia.innerHTML = "El número para adivinar es mas BAJO"
                    $diferencia.classList.remove("visibility-hidden")
                    $formNumero.reset()
                }else{
                    $formNumero.reset()
                    let mejorPuntaje = contador 
                    $containerWinner.classList.add("margin-left-0")
                    $puntaje.innerHTML = `${mejorPuntaje}`

                    if(ls.getItem("mayorPuntuacion") < mejorPuntaje){
                        ls.setItem("mayorPuntuacion", mejorPuntaje)
                    }
                     }
            }
            if(numeroJugador != numeroRandom){
                $intentosRestantes.innerHTML = `${contador}`
            }
            if(contador == 0){
                $containerLoser.classList.add("margin-left-0")
            }
    })
}

    const recargarSitio = () => {
        document.addEventListener("click", e => {
            if(e.target === $btnReplayWinner){
                location.reload()
            }
            if(e.target === $btnReplayLoser){
                location.reload()
            }
        })
    }

    const guardarPuntajeMaximo = () => {
        document.addEventListener("DOMContentLoaded", (e) => {
            if(ls.getItem("mayorPuntuacion") === null)ls.setItem("mayorPuntuacion", 0)
            $puntajeLocalStorage.innerHTML = `${ls.getItem("mayorPuntuacion")}`
         })
    }

    const colorTitulo = () => {
        setInterval(() => {
            $titleGame.classList.toggle("bg-red")
        }, 500);
    }

     adivinarNumero()
     recargarSitio()
     guardarPuntajeMaximo()
     colorTitulo()


