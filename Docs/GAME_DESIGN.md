# Game Design - World Conquest

Documento de design do mod **World Conquest**.

---

## Pilares do design

### 1. Mapa mundial como tabuleiro

O mapa mundial deixa de ser apenas uma tela de viagem e vira a camada principal de estratégia.

### 2. Expansão simples, decisão profunda

A ação básica é conquistar tiles vizinhos, mas a decisão estratégica vem de escolher quais regiões valem mais.

### 3. Economia territorial

Território precisa gerar valor real para a colônia.

### 4. Conflito por fronteira

A guerra deve acontecer por controle de regiões, não apenas por raids aleatórias.

### 5. Crescimento persistente

O jogador deve sentir que sua colônia virou uma potência mundial ao longo do tempo.

---

## Tipos de território

| Tipo | Função |
|---|---|
| Neutro | Pode ser conquistado |
| Dominado | Pertence a uma cidade/facção |
| Fronteira | Tile dominado próximo ao inimigo |
| Estratégico | Gera recurso raro ou bônus |
| Capital | Região central de uma cidade |
| Contestado | Tile sob disputa/influência dividida |

---

## Renda inicial

Regra MVP:

```text
+10 prata por tile dominado por dia
```

Regra futura:

```text
Renda = base do tile + bônus do bioma + bônus de estrutura + bônus de influência
```

---

## Expansão

### MVP

- Jogador conquista tile neutro.
- Tile precisa ser adjacente.
- Sem custo inicial.

### Futuro

Possíveis custos:

- Prata.
- Comida.
- Caravana.
- Tempo de ocupação.
- Item administrativo.
- Pontos de influência.

---

## Defesa

Defesa representa a dificuldade para outro grupo tomar o tile.

Estruturas futuras:

| Estrutura | Bônus |
|---|---|
| Posto militar | Defesa básica |
| Torre de vigia | Visão/fronteira |
| Radar | Alerta antecipado |
| Bunker | Defesa alta |
| Base avançada | Defesa e influência |

---

## Guerra

Uma guerra deve seguir etapas claras:

```text
Declarar guerra
↓
Esperar tempo de preparação
↓
Atacar tile de fronteira
↓
Resolver combate/evento
↓
Transferir domínio se vencer
```

---

## Diplomacia

Estados planejados:

| Estado | Efeito |
|---|---|
| Neutro | Sem bônus ou penalidade |
| Aliado | Sem ataque direto |
| Guerra | Permite conquista |
| Protegido | Uma facção defende outra |
| Vassalo | Paga tributo |

---

## Eventos globais

Eventos que criam disputa no mapa mundial:

- Mina rara descoberta.
- Ruína tecnológica.
- Depósito militar abandonado.
- Base pirata avançada.
- Infestação em região valiosa.
- Queda de nave com componentes.
- Campo de urânio exposto.

---

## Progressão ideal

### Early game

- Poucos tiles.
- Renda pequena.
- Expansão local.

### Mid game

- Fronteiras maiores.
- Recursos estratégicos.
- Primeiros conflitos.

### Late game

- Impérios grandes.
- Guerras por região.
- Diplomacia.
- Eventos mundiais raros.

---

## Regra de ouro

O mod não deve substituir o RimWorld.

Ele deve criar uma camada estratégica acima dele, fazendo a colônia ter impacto no planeta inteiro.
