# Escopo Básico - World Conquest

## 1. Conceito

World Conquest é uma camada estratégica sobre o mapa mundial do RimWorld.

O jogador não controla apenas uma base. Ele controla uma cidade/colônia que pode expandir influência sobre tiles vizinhos, gerar renda, defender fronteiras e competir contra outras facções.

## 2. MVP

O MVP precisa provar a ideia central sem tentar criar guerra completa logo no início.

### Funcionalidades obrigatórias

- Detectar a colônia principal do jogador.
- Registrar tiles controlados.
- Permitir domínio de tiles adjacentes.
- Exibir cor de domínio no mapa mundial.
- Gerar prata diária baseada na quantidade de tiles.
- Salvar os dados no save.

### Funcionalidades fora do MVP

- Guerra avançada.
- Diplomacia completa.
- IA expandindo território.
- Multiplayer real.
- Eventos globais complexos.
- Interface visual final.

## 3. Regras de território

### Tile neutro

Um tile sem dono pode ser conquistado se estiver adjacente a um território do jogador.

### Tile dominado

Um tile dominado possui:

- Tile ID.
- Dono.
- Facção.
- Cor.
- Valor de renda.
- Defesa.
- Influência.

### Fronteira

A expansão só pode acontecer em tiles vizinhos ao território atual.

## 4. Economia

Regra inicial simples:

```text
Cada tile dominado gera +10 prata por dia.
```

Exemplo:

```text
15 tiles dominados = 150 prata por dia.
```

Depois, a renda poderá variar por bioma, riqueza ou ponto especial.

## 5. Expansão

### Versão simples

O jogador abre uma opção no mapa mundial:

```text
Conquistar território
```

Se o tile for válido:

- O tile recebe o dono do jogador.
- A cor aparece no mapa.
- A renda diária aumenta.

### Versão futura

A conquista exigirá caravana, item administrativo, tempo de ocupação ou combate.

## 6. Defesa

No MVP, defesa pode ser apenas um número.

No futuro, defesa poderá vir de:

- Posto militar.
- Torre de vigia.
- Radar.
- Bunker.
- Base avançada.

## 7. Interface planejada

Aba: **World Conquest**

Informações:

- Nome da cidade.
- Territórios dominados.
- Renda diária.
- Defesa média.
- Facções inimigas.
- Ranking global.

## 8. Prioridade de desenvolvimento

1. Salvar dados do mod.
2. Criar classe de território.
3. Criar gerenciador global.
4. Pintar mapa mundial.
5. Gerar prata diária.
6. Criar botão de conquistar tile.
7. Criar tela básica de status.
