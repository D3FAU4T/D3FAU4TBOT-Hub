const answerSlots = document.getElementById('answerslots');
const wordCount = document.getElementById('wordcount');
const wordpointtotal = document.getElementById('wordpointtotal');
const letterShuffles = document.getElementById('letterShuffles');
const timebar = document.getElementById('timebar');
const configSetting = document.getElementById('configSetting');
const setting = document.getElementById('setting');
const settingClose = document.getElementById('settingClose');
const contentTop = document.getElementById('contentTop');
const configPopup = document.getElementById('configPopup');
const jsoninput = document.getElementById('jsoninput');
const wordMode = document.getElementById('wordMode');
const bottomConfig = document.getElementById('bottomConfig');
const wordlist = document.getElementById('wordlist');
const thirdRow = document.getElementById('thirdRow');
const fourthRow = document.getElementById('fourthRow');
const topbar = document.getElementById('topbar');
const languageSetting = document.getElementById('languageSetting');
const languageSettingBtn = document.getElementById('languageSettingBtn');
const languagePopup = document.getElementById('languagePopup');
const languageSettingClose = document.getElementById('languageSettingClose');
const languageDown = document.getElementById('languageDown');
const languageUp = document.getElementById('languageUp');
const languageNumber = document.getElementById('languageNumber');
const langUI = document.getElementById('langUI');
const langLanguage = document.getElementById('LangLanguage');
const qr1 = document.getElementById('QR1');
const qr2 = document.getElementById('QR2');
const formWords = document.getElementById('formWords');
const congratulations = document.getElementById('congratulations');
const levelCompleted = document.getElementById('levelCompleted');
const topLevelNumber = document.getElementById('topLevelNumber');
const goal = document.getElementById('GOAL');
const level = document.getElementById('level');
const goalNumber = document.getElementById('goalNumber');
const settingLang = document.getElementById('settingLang');
const easyMode = document.getElementById('easyMode');
const easyModeText = document.getElementById('easyModeText');
const timebarLine = document.getElementById('timebarLine');
const sync = document.getElementById('sync');
const syncTxt = document.getElementById('syncTxt');
const syncSubTxt = document.getElementById('syncSubTxt');
const syncingTxt = document.getElementById('syncingTxt');
const syncSetter = document.getElementById('syncSetter');
const copyToClipboard = document.getElementById('copyToClipboard');

let userId = 'System';

let firstTimeVisiting = true;
const languages = ["English", "Português", "Français"];

const template = `{
    "lang": "English",
    "fakeLetters": "",
    "hiddenLetters": "",
    "reveal": true,
    "level": "1",
    "timebar": {
        "timerPercentage": 100,
        "locks": {
            "total": 3,
            "expired": 0
        }
    },
    "column1": [
        { "word": "coned", "username": "chantell_nz", "locked": false, "index": 0 },
        { "word": "demon", "username": "draconis256_", "locked": false, "index": 1 },
        { "word": "denim", "username": "chantell_nz", "locked": false, "index": 2 },
        { "word": "medic", "username": "arch_a_tri", "locked": false, "index": 3 }
    ],
    "column2": [
        { "word": "mince", "username": "arch_a_tri", "locked": false, "index": 4 },
        { "word": "mined", "username": "d3fau4t", "locked": false, "index": 5 },
        { "word": "coined", "username": "arch_a_tri", "locked": false, "index": 6 },
        { "word": "income", "username": "chantell_nz", "locked": false, "index": 7 }
    ],
    "column3": [
        { "word": "minced", "username": "d3fau4t", "locked": false, "index": 8 },
        { "word": "demonic", "username": "draconis256_", "locked": false, "index": 9 }
    ]
}`;

const scriptTranslation = {
    English: {
        wordListTxt: "Word List",
        wordListBelow: "Type words below separated with space. Put a ? to indicate that the word has not been found yet.",
        fakeLettersTxt: "Fake Letters",
        hiddenLettersTxt: "Hidden Letters",
        revealTxt: "Reveal",
        settingLevel: "Level",
        settingLocks: "Locks",
        settingUnlocked: "Unlocked",
        settingTime: "Time",
        JSONconfig: "JSON Config",
        JSONtxt: "Paste the JSON configuration in order to update the board. Example format below.",
        topbarFirstOne: ["BE THE FIRST ONE TO", "FIND AN ANAGRAM!"],
        topbarFound: "FOUND",
        topbarCongrats: ["CONGRATULATIONS!", "LEVEL COMPLETED!"],
        topbarOneFake: ["ATTENTION! THERE IS A", "FAKE LETTER"],
        topbarFakeHidden: ["BEWARE OF THE", "FAKE LETTER", "AND THE", "HIDDEN LETTER!"],
        words: "WORDS",
        syncing: "SYNCING LAST HITS"
    },
    Português: {
        wordListTxt: "Lista de Palavras",
        wordListBelow: "Digite abaixo as palavras separadas por um espaço. Colocar um ? para indicar que a palavra ainda não foi encontrada.",
        fakeLettersTxt: "Letras Falsas",
        hiddenLettersTxt: "Letras Escondidas",
        revealTxt: "Revelar",
        settingLevel: "Nível",
        settingLocks: "Cadeados",
        settingUnlocked: "Desbloqueado",
        settingTime: "Tempo",
        JSONconfig: "Config JSON",
        JSONtxt: "Cole a configuração JSON para atualizar a tela. Exemplo abaixo.",
        topbarFirstOne: ["SEJA O PRIMEIRO A", "ENCONTRAR O ANAGRAMA!"],
        topbarFound: "ENCONTROU",
        topbarCongrats: ["PARABÉNS!", "NÍVEL COMPLETADO!"],
        topbarOneFake: ["ATENÇÃO! HÁ UMA", "LETRA FALSA"],
        topbarFakeHidden: ["ATENÇÃO COM A", "LETRA FALSA", "E A", "LETRA ESCONDIDA!"],
        words: "PALAVRAS",
        syncing: "SINCRONIZANDO"
    },
    Français: {
        wordListTxt: "Liste de mots",
        wordListBelow: "Tapez les mots ci-dessous séparés par un espace. Mettre un ? pour indiquer que le mot n'a pas encore été trouvé.",
        fakeLettersTxt: "Lettres fausses",
        hiddenLettersTxt: "Lettres cachées",
        revealTxt: "Révéler",
        settingLevel: "Niveau",
        settingLocks: "Verrous",
        settingUnlocked: "Débloqué",
        settingTime: "Temps",
        JSONconfig: "Config JSON",
        JSONtxt: "Collez la configuration JSON pour mettre à jour l'écran. Exemple ci-dessous.",
        topbarFirstOne: ["SOYEZ LA PREMIÈRE PERSONNE À", "TROUVER UNE ANAGRAMME!"],
        topbarFound: "TROUVÉ",
        topbarCongrats: ["FÉLICITATIONS!", "NIVEAU COMPLÉTÉ!"],
        topbarOneFake: ["ATTENTION! IL Y A UNE", "FAUSSE LETTRE "],
        topbarFakeHidden: ["ATTENTION À LA", "FAUSSE LETTRE", "ET À LA", "LETTRE CACHÉE!"],
        words: "MOTS",
        syncing: "SYNCHRONISATION"
    }
}

const board = JSON.parse(template);
jsoninput.placeholder = template;
localStorage.setItem('wordJSON', template);
wordMode.checked = false;
answerSlots.innerHTML = createBoard(board);
addHover();

sync.addEventListener("change", () => {
    let json = getList();
    if (sync.checked) {
        syncingTxt.innerHTML = `<span id='syncSwitch'>${scriptTranslation[json.lang].syncing}</span>`;
        syncSetter.className = 'containerLetters lettersExit';
    } else {
        syncSetter.className = 'containerLetters';
        syncingTxt.innerHTML = '';
    }
});

configSetting.addEventListener("click", () => {
    setting.hidden = false;
    setTimeout(() => setting.className = "popup awards popup-enter-done", 300);
});
settingClose.addEventListener("click", () => {
    setting.className = "popup popup-exit awards";
    setTimeout(() => {
        setting.hidden = true;
        setting.className = "popup popup-enter-active awards";
    }, 300);
});
languageSettingBtn.addEventListener("click", () => {
    languageSetting.hidden = false;
    setTimeout(() => languageSetting.className = "popup awards popup-enter-done", 300);
});
languageSettingClose.addEventListener("click", () => {
    languageSetting.className = "popup popup-exit awards";
    setTimeout(() => {
        languageSetting.hidden = true;
        languageSetting.className = "popup popup-enter-active awards";
    }, 300);
});
languageUp.addEventListener("click", () => {
    let current = languageNumber.textContent;
    const index = languages.findIndex(lang => lang === current);
    let nextLang = languages[index + 1];
    if (!nextLang) return;
    modifyLanguage(nextLang);
    updateNick()
    addHover()
});
languageDown.addEventListener("click", () => {
    let current = languageNumber.textContent;
    const index = languages.findIndex(lang => lang === current);
    let prevLang = languages[index - 1];
    if (!prevLang) return;
    modifyLanguage(prevLang);
    updateNick()
    addHover()
});

wordMode.addEventListener("change", () => {
    if (wordMode.checked) {
        let json = getList();
        const words = json.column1
            .concat(json.column2, json.column3)
            .flatMap(obj => obj.word);

        bottomConfig.innerHTML =
            `<h4 id="wordListTxt">${scriptTranslation[json.lang].wordListTxt}</h4>
            <p id="wordListBelow">${scriptTranslation[json.lang].wordListBelow}</p>
            <input class="" type="text" placeholder="E.g.: demonic demon coined? income? coned" value="${firstTimeVisiting === true ? "" : words.join(' ')}" id="wordlist">
            <label class="error"></label>`;

        bottomConfig.style.height = "210px";

        thirdRow.innerHTML =
            `<span>
            <h4 id="fakeLettersTxt">${scriptTranslation[json.lang].fakeLettersTxt}</h4>
            <input class="" type="text" placeholder="E.g.: def" value="${json.fakeLetters}" id="fakeLetters">
            <label class="error"></label>
        </span>
        <span>
            <h4 id="hiddenLettersTxt">${scriptTranslation[json.lang].hiddenLettersTxt}</h4>
            <input class="" type="text" placeholder="E.g.: flt" value="${json.hiddenLetters}" id="hiddenLetters">
            <label class="error"></label>
        </span>
        <span class="onoff">
        <h4 id="revealTxt">${scriptTranslation[json.lang].revealTxt}</h4>
            <input id="reveal" title="Reveal" type="checkbox">
            <label for="reveal"></label>
        </span>`;

        fourthRow.innerHTML =
            `<span>
            <h4 id="settingLevel">${scriptTranslation[json.lang].settingLevel}</h4>
            <span class="vol">
                <button class="down" id="levelDown"></button>
                <p id="levelNumber">${json.level}</p>
                <button class="up" id="levelUp"></button>
            </span>
        </span>
        <span>
            <h4 id="settingLocks">${scriptTranslation[json.lang].settingLocks}</h4>
            <span class="vol">
                <button class="down" id="tLockDown"></button>
                <p id="tLockNumber">${json.timebar.locks.total}</p>
                <button class="up" id="tLockUp"></button>
            </span>
        </span>
        <span>
            <h4 id="settingUnlocked">${scriptTranslation[json.lang].settingUnlocked}</h4>
            <span class="vol">
                <button class="down" id="uLockDown"></button>
                <p id="uLockNumber">${json.timebar.locks.expired}</p>
                <button class="up" id="uLockUp"></button>
            </span>
        </span>
        <span>
            <h4 id="settingTime">${scriptTranslation[json.lang].settingTime}</h4>
            <span class="vol">
                <button class="down" id="timebarDown"></button>
                <p id="timebarNumber">${json.timebar.timerPercentage}</p>
                <button class="up" id="timebarUp"></button>
            </span>
        </span>`;

        // REVEAL
        const reveal = document.getElementById("reveal");
        reveal.checked = json.reveal;
        reveal.addEventListener("change", () => {
            let json = getList();
            json.reveal = reveal.checked;
            saveList(json);
            answerSlots.innerHTML = createBoard(json);
            updateNick()
            addHover()
        });

        // FAKE LETTERS
        const fakeLetters = document.getElementById("fakeLetters");
        fakeLetters.addEventListener("input", () => {
            let json = getList();
            json.fakeLetters = fakeLetters.value;
            saveList(json);
            answerSlots.innerHTML = createBoard(json);
            updateNick()
            addHover()
        });

        // HIDDEN LETTERS
        const hiddenLetters = document.getElementById("hiddenLetters");
        hiddenLetters.addEventListener("input", () => {
            let json = getList();
            json.hiddenLetters = hiddenLetters.value;
            saveList(json);
            answerSlots.innerHTML = createBoard(json);
            updateNick()
            addHover()
        });

        // LEVEL
        const levelDownBtn = document.getElementById("levelDown");
        let levelDownInterval = null;
        levelDownBtn.addEventListener("mousedown", () => {
            levelDownInterval = setInterval(() => {
                const levelNumber = document.getElementById("levelNumber");
                if (parseInt(levelNumber.textContent) <= 1) return;
                levelNumber.textContent = parseInt(levelNumber.textContent) - 1;
                let json = getList();
                json.level = levelNumber.textContent;
                answerSlots.innerHTML = createBoard(json);
                saveList(json);
                updateNick()
                addHover()
            }, 100);
        });
        levelDownBtn.addEventListener("mouseup", () => {
            clearInterval(levelDownInterval);
            updateNick()
            addHover()
        });
        levelDownBtn.addEventListener("click", () => {
            const levelNumber = document.getElementById("levelNumber");
            if (parseInt(levelNumber.textContent) <= 1) return;
            levelNumber.textContent = parseInt(levelNumber.textContent) - 1;
            let json = getList();
            json.level = levelNumber.textContent;
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            updateNick()
            addHover()
        });

        // add event listener to level up button
        const levelUpBtn = document.getElementById("levelUp");
        let levelUpInterval = null;
        levelUpBtn.addEventListener("mousedown", () => {
            levelUpInterval = setInterval(() => {
                const levelNumber = document.getElementById("levelNumber");
                levelNumber.textContent = parseInt(levelNumber.textContent) + 1;
                let json = getList();
                json.level = levelNumber.textContent;
                answerSlots.innerHTML = createBoard(json);
                saveList(json);
                updateNick()
                addHover()
            }, 100);
        });
        levelUpBtn.addEventListener("mouseup", () => {
            clearInterval(levelUpInterval);
            updateNick()
            addHover()
        });
        levelUpBtn.addEventListener("click", () => {
            const levelNumber = document.getElementById("levelNumber");
            levelNumber.textContent = parseInt(levelNumber.textContent) + 1;
            let json = getList();
            json.level = levelNumber.textContent;
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            updateNick()
            addHover()
        });

        // TOTAL LOCK
        const tLockDownBtn = document.getElementById("tLockDown");
        tLockDownBtn.addEventListener("click", () => {
            const tLockNumber = document.getElementById("tLockNumber");
            if (parseInt(tLockNumber.textContent) <= 2) return;
            tLockNumber.textContent = parseInt(tLockNumber.textContent) - 1;
            let json = getList();
            json.timebar.locks.total = parseInt(tLockNumber.textContent);
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            updateNick()
            addHover()
        });

        const tLockUpBtn = document.getElementById("tLockUp");
        tLockUpBtn.addEventListener("click", () => {
            const tLockNumber = document.getElementById("tLockNumber");
            if (parseInt(tLockNumber.textContent) >= 5) return;
            tLockNumber.textContent = parseInt(tLockNumber.textContent) + 1;
            let json = getList();
            json.timebar.locks.total = parseInt(tLockNumber.textContent);
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            updateNick()
            addHover()
        });

        // UNLOCKED
        const uLockDownBtn = document.getElementById("uLockDown");
        uLockDownBtn.addEventListener("click", () => {
            const uLockNumber = document.getElementById("uLockNumber");
            if (parseInt(uLockNumber.textContent) == 0) return;
            uLockNumber.textContent = parseInt(uLockNumber.textContent) - 1;
            let json = getList();
            json.timebar.locks.expired = parseInt(uLockNumber.textContent);
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            updateNick()
            addHover()
        });

        const uLockUpBtn = document.getElementById("uLockUp");
        uLockUpBtn.addEventListener("click", () => {
            const uLockNumber = document.getElementById("uLockNumber");
            let json = getList();
            if (parseInt(uLockNumber.textContent) == json.timebar.locks.total) return;
            uLockNumber.textContent = parseInt(uLockNumber.textContent) + 1;
            json.timebar.locks.expired = parseInt(uLockNumber.textContent);
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            updateNick()
            addHover()
        });

        // TIMEBAR
        const timebarDownBtn = document.getElementById("timebarDown");
        let timebarDownInterval = null;
        timebarDownBtn.addEventListener("mousedown", () => {
            timebarDownInterval = setInterval(() => {
                const timebarNumber = document.getElementById("timebarNumber");
                if (parseInt(timebarNumber.textContent) <= 0) return;
                timebarNumber.textContent = parseInt(timebarNumber.textContent) - 1;
                let json = getList();
                json.timebar.timerPercentage = parseInt(timebarNumber.textContent);
                answerSlots.innerHTML = createBoard(json);
                saveList(json);
                updateNick()
                addHover()
            }, 100);
        });
        timebarDownBtn.addEventListener("mouseup", () => {
            clearInterval(timebarDownInterval);
            updateNick()
            addHover()
        });
        timebarDownBtn.addEventListener("click", () => {
            const timebarNumber = document.getElementById("timebarNumber");
            if (parseInt(timebarNumber.textContent) <= 0) return;
            timebarNumber.textContent = parseInt(timebarNumber.textContent) - 1;
            let json = getList();
            json.timebar.timerPercentage = parseInt(timebarNumber.textContent);
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            updateNick()
            addHover()
        });

        const timebarUpBtn = document.getElementById("timebarUp");
        let timebarUpInterval = null;
        timebarUpBtn.addEventListener("mousedown", () => {
            timebarUpInterval = setInterval(() => {
                const timebarNumber = document.getElementById("timebarNumber");
                if (parseInt(timebarNumber.textContent) >= 100) return;
                timebarNumber.textContent = parseInt(timebarNumber.textContent) + 1;
                let json = getList();
                json.timebar.timerPercentage = parseInt(timebarNumber.textContent);
                answerSlots.innerHTML = createBoard(json);
                saveList(json);
                updateNick()
                addHover()
            }, 100);
        });
        timebarUpBtn.addEventListener("mouseup", () => {
            clearInterval(timebarUpInterval);
            updateNick()
            addHover()
        });
        timebarUpBtn.addEventListener("click", () => {
            const timebarNumber = document.getElementById("timebarNumber");
            if (parseInt(timebarNumber.textContent) >= 100) return;
            timebarNumber.textContent = parseInt(timebarNumber.textContent) + 1;
            let json = getList();
            json.timebar.timerPercentage = parseInt(timebarNumber.textContent);
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            updateNick()
            addHover()
        });
        if (firstTimeVisiting) firstTimeVisiting = false;
    } else {
        thirdRow.innerHTML = '';
        fourthRow.innerHTML = '';
        let json = getList();
        let words = JSON.stringify(json, null, 2);
        bottomConfig.innerHTML =
            `<h4 id="JSONconfig">${scriptTranslation[json.lang].JSONconfig}</h4>
              <p id="JSONtxt">${scriptTranslation[json.lang].JSONtxt}</p>
              <textarea class="" placeholder='${template}' id="jsoninput">${words === 'null' ? "" : words}</textarea>
              <label class="error"></label>`;
        bottomConfig.style.height = "420px";
        updateNick()
        addHover()
    }
});

bottomConfig.addEventListener("input", (event) => {
    try {
        let json = getList();
        const usernames = [...json.column1, ...json.column2, ...json.column3].map((item) => item.username);
        if (event.target.tagName.toLowerCase() === "input") {
            console.log(event.target.value.split(''));
            const board = { ...createJSON(event.target.value.split(' '), usernames, false), level: json.level, timebar: json.timebar, lang: json.lang, fakeLetters: json.fakeLetters, hiddenLetters: json.hiddenLetters };
            saveList(board);
            answerSlots.innerHTML = createBoard(board);
            updateNick()
            addHover()
        } else if (event.target.tagName.toLowerCase() === "textarea") {
            saveList(JSON.parse(event.target.value));
            answerSlots.innerHTML = createBoard(json);
            updateNick()
            addHover()
        }
    } catch (err) { };
});

let maxWidth = contentTop.clientWidth;
let maxHeight = contentTop.clientHeight;
window.addEventListener("resize", resize);
resize();

function resize() {
    let width = window.innerWidth;
    let height = window.innerHeight;
    let isMax = width >= maxWidth && height >= maxHeight;
    let scale = Math.min(width / maxWidth, height / maxHeight);
    contentTop.style.transform = isMax ? '' : 'scale(' + scale + ')';
    configPopup.style.transform = isMax ? '' : 'scale(' + scale + ')';
    languagePopup.style.transform = isMax ? '' : 'scale(' + scale + ')';
    jsoninput.style.height = (maxHeight - 60) + "px";
}
// RESIZING THING I COPIED FROM INTERNET

function updateTimer(percentage, numlocks, remaining) {
    const locks = [];
    const expiredLocks = numlocks - remaining;

    for (let i = 0; i < numlocks; i++) {
        let lockClass = "mark";
        if (i >= expiredLocks) lockClass += " end";
        locks.push(`<div class="${lockClass}" style="left: ${100 * (i + 1) / (numlocks + 1)}%;"></div>`);
    }

    const lockString = locks.join("\n");

    return `
      <span style="width: ${percentage}%; transition-duration: 117000ms;"></span>
      ${lockString}
    `;
}

function saveList(json) {
    localStorage.setItem('wordJSON', JSON.stringify(json));
}

function getList() {
    return JSON.parse(localStorage.getItem('wordJSON'));
}

function createJSON(words, username, locked) {

    const board = {
        lang: "English",
        fakeLetters: "",
        hiddenLetters: "",
        reveal: false,
        level: 1,
        timebar: {
            timerPercentage: 100,
            locks: {
                total: 3,
                expired: 0
            }
        },
        column1: [],
        column2: [],
        column3: []
    };

    words.sort((a, b) => a.replace(/\?/g, '').length - b.replace(/\?/g, '').length || a.replace(/\?/g, '').localeCompare(b.replace(/\?/g, '')));
    const wordsPerColumn = words.length >= 15 ? Math.ceil(words.length / 3) + 1 : Math.ceil(words.length / 3);

    for (let i = 0; i < words.length; i++) {
        const columnIdx = Math.floor(i / wordsPerColumn);
        const wordObj = { word: words[i], username: username[i] || 'd3fau4tbot', locked, index: i };
        board[`column${columnIdx + 1}`].push(wordObj);
    }

    return board;
}

function updateUsernameByIndex(json, index, username) {
    let element = null;

    element = json.column1.find(obj => obj.index == index);
    if (element) {
        element.username = username.toLowerCase();
        return json;
    }

    element = json.column2.find(obj => obj.index == index);
    if (element) {
        element.username = username.toLowerCase();
        return json;
    }

    element = json.column3.find(obj => obj.index == index);
    if (element) {
        element.username = username.toLowerCase();
        return json;
    }

    return null;
}

// This function creates the slots, I tried putting an id with the index, but if I do that the CSS glitches '-'
// Ok so far so good, but I remember as soon as I added the mouseover event, the blanks went to the left side
function createSlot(word, username, locked, index) {
    let letters = word.split('')
    if (letters.includes('?')) {
        letters.pop();
        let slot =
            `<div class="slot" id="ourSlot${index}">
        <div class="nick" contenteditable="true" data-index="${index}"></div>
        <div class="letters">\n`;
        letters.forEach(letter => slot += `             <div class="letter"></div>\n`);
        slot += `       </div>\n</div>`;
        return slot;
    } else {
        let slot =
            // like that?
            `<div class="slot hit${locked ? "" : " expired"}" id="ourSlot${index}">
        <div class="${locked ? "padlock" : ""}" id="ourLock${index}"></div>
        <div class="animHit"></div>
        <div class="nick" contenteditable="true" data-index="${index}">${username}</div>
            <div class="letters">\n`;
        letters.forEach(letter => slot += `             <div class="letter"><span>${letter}</span></div>\n`);
        slot += `       </div>\n</div>`;
        return slot;
    }
}

function createColumn(columnArr, startingIndex) {
    let column = '';
    columnArr.forEach((obj, i) => column += createSlot(obj.word, obj.username, obj.locked, startingIndex + i) + '\n');
    return column;
}

function createBoard(boardObj) {
    let board = '<div class="column">\n' + createColumn(boardObj.column1, 0) + '\n</div>\n';
    board += '<div class="column">\n' + createColumn(boardObj.column2, boardObj.column1.length) + '\n</div>';
    board += '<div class="column">\n' + createColumn(boardObj.column3, boardObj.column1.length + boardObj.column2.length) + '\n</div>';

    let numOfTotalWords = 0;
    let numOfFoundedWords = 0;
    let totalPoint = 0;
    let totalPointForPointbar = 0;
    let words = '';

    for (const col of ['column1', 'column2', 'column3']) {
        for (const obj of boardObj[col]) {
            numOfTotalWords++;
            totalPointForPointbar += wordPoint(obj.word);
            if (obj.word.includes('?')) continue;
            totalPoint += wordPoint(obj.word);
            words += obj.word + ' ';
            numOfFoundedWords++;
        }
    }

    // Path is defined above, very above
    const totalLength = timebarLine.getTotalLength();
    const segmentLength = totalLength / numOfTotalWords;
    timebarLine.style.strokeDasharray = `${numOfFoundedWords * segmentLength},${totalLength}`;
    timebarLine.style.strokeDashoffset = segmentLength;
    topLevelNumber.textContent = boardObj.level;
    let passingPoints = 0;
    switch (boardObj.level) {
        case '1': passingPoints = Math.round(totalPointForPointbar * 0.45); break;
        case '2': passingPoints = Math.round(totalPointForPointbar * 0.47); break;
        case '3': passingPoints = Math.round(totalPointForPointbar * 0.48); break;
        case '4': passingPoints = Math.round(totalPointForPointbar * 0.5); break;
        case '5': passingPoints = Math.round(totalPointForPointbar * 0.51); break;
        case '6': passingPoints = Math.round(totalPointForPointbar * 0.52); break;
        case '7': passingPoints = Math.round(totalPointForPointbar * 0.53); break;
        case '8': passingPoints = Math.round(totalPointForPointbar * 0.56); break;
        case '9': passingPoints = Math.round(totalPointForPointbar * 0.57); break;
        case '10': passingPoints = Math.round(totalPointForPointbar * 0.58); break;
        case '11': passingPoints = Math.round(totalPointForPointbar * 0.59); break;
        case '12': passingPoints = Math.round(totalPointForPointbar * 0.61); break;
        case '13': passingPoints = Math.round(totalPointForPointbar * 0.59); break;
        case '14': passingPoints = Math.round(totalPointForPointbar * 0.63); break;
        case '15': passingPoints = Math.round(totalPointForPointbar * 0.65); break;
        case '16': passingPoints = Math.round(totalPointForPointbar * 0.67); break;
        case '17': passingPoints = Math.round(totalPointForPointbar * 0.68); break;
        case '18': passingPoints = Math.round(totalPointForPointbar * 0.69); break;
        case '19': passingPoints = Math.round(totalPointForPointbar * 0.7); break;
        case '20': passingPoints = Math.round(totalPointForPointbar * 0.73); break;
        case '21': passingPoints = Math.round(totalPointForPointbar * 0.74); break;
        case '22': passingPoints = Math.round(totalPointForPointbar * 0.75); break;
        case '23': passingPoints = Math.round(totalPointForPointbar * 0.76); break;
        case '24': passingPoints = Math.round(totalPointForPointbar * 0.78); break;
        case '25': passingPoints = Math.round(totalPointForPointbar * 0.79); break;
        case '26': passingPoints = Math.round(totalPointForPointbar * 0.81); break;
        case '27': passingPoints = Math.round(totalPointForPointbar * 0.82); break;
        case '28': passingPoints = Math.round(totalPointForPointbar * 0.83); break;
        case '29': passingPoints = Math.round(totalPointForPointbar * 0.85); break;
        case '30': passingPoints = Math.round(totalPointForPointbar * 0.86); break;
        case '31': passingPoints = Math.round(totalPointForPointbar * 0.87); break;
        case '32': passingPoints = Math.round(totalPointForPointbar * 0.89); break;
        case '33': passingPoints = Math.round(totalPointForPointbar * 0.9); break;
        default: passingPoints = Math.round(totalPointForPointbar * 0.9); break;
    }

    goalNumber.textContent = `${totalPoint}/${passingPoints}`;
    words = words.split(' ');
    words.pop();

    if (totalPoint < passingPoints) {
        wordpointtotal.className = "infosMeta";
        timebarLine.style.stroke = "rgb(26,255,238)";
        let word = words[words.length - 1];
        let username = '';
        for (const col of ['column1', 'column2', 'column3']) {
            let breakNow = false;
            for (const obj of boardObj[col]) {
                if (obj.word === word) {
                    username = obj.username;
                    breakNow = true;
                    break;
                }
            }
            if (breakNow) break;
        }

        if (boardObj.fakeLetters.length > 0 && boardObj.hiddenLetters.length == 0) {
            topbar.innerHTML =
                `<div class="notHit">
                <span class="invalid blink">${scriptTranslation[boardObj.lang].topbarOneFake[0]}<br>
                    <strong class="red">${scriptTranslation[boardObj.lang].topbarOneFake[1]}</strong>
                </span>
            </div>`;
        } else if (boardObj.fakeLetters.length > 0 && boardObj.hiddenLetters.length > 0) {
            topbar.innerHTML =
                `<div class="notHit">
                <span class="hidden blink">${scriptTranslation[boardObj.lang].topbarFakeHidden[0]} <strong class="red">${scriptTranslation[boardObj.lang].topbarFakeHidden[1]}</strong>
                    <br>${scriptTranslation[boardObj.lang].topbarFakeHidden[2]} <strong class="yellow">${scriptTranslation[boardObj.lang].topbarFakeHidden[3]}</strong>
                </span>
            </div>`;
        } else {
            if (totalPoint == 0) {
                topbar.innerHTML =
                    `<div class="notHit">
                    <span>${scriptTranslation[boardObj.lang].topbarFirstOne[0]}<br>${scriptTranslation[boardObj.lang].topbarFirstOne[1]}</span>
                </div>`;
                timebarLine.style.strokeOpacity = '0';
            } else {
                topbar.innerHTML =
                    `<div class="hit">
                <div>
                    <span class="nick">${username.toUpperCase()} </span>
                    <span>${scriptTranslation[boardObj.lang].topbarFound}</span>
                </div>
                <p>"${word}"</p>
                </div>`;
                timebarLine.style.strokeOpacity = '1';
            }
        }

    } else {
        wordpointtotal.className = "infosMeta animGoal";
        timebarLine.style.stroke = "rgb(236,197,80)";
        topbar.innerHTML =
            `<div class="levelCompleted">
                <span id="congratulations">${scriptTranslation[boardObj.lang].topbarCongrats[0]}</span>
                <p id="levelCompleted">${scriptTranslation[boardObj.lang].topbarCongrats[1]}</p>
            </div>`;
    }

    const longestWord = boardObj.column3[boardObj.column3.length - 1].word.replace(/\?/g, '');
    letterShuffles.innerHTML = createLetters(longestWord, boardObj.fakeLetters, boardObj.hiddenLetters, boardObj.reveal);

    wordCount.innerHTML =
        `<span>
            <h6>${scriptTranslation[boardObj.lang].words}</h6>
            <p><strong>${words.length}</strong> /${words.length}</p>
        </span>`;

    timebar.innerHTML = updateTimer(boardObj.timebar.timerPercentage, boardObj.timebar.locks.total, boardObj.timebar.locks.expired);
    return board;
}

function wordPoint(input) {
    let pointMap = { "a": 1, "b": 3, "c": 3, "d": 2, "e": 1, "f": 4, "g": 2, "h": 4, "i": 1, "j": 8, "k": 5, "l": 1, "m": 3, "n": 1, "o": 1, "p": 3, "q": 10, "r": 1, "s": 1, "t": 1, "u": 1, "v": 4, "w": 4, "x": 8, "y": 4, "z": 10 }
    let word = input.normalize('NFD').replace(/[\u0300-\u036f]/g, '').replace(/\?/g, '').toLowerCase().split('');
    let count = 0;
    word.forEach(letter => count += pointMap[letter] || 0);
    return count;
}

function createLetters(word, fakeLetters, hiddenLetters, reveal) {
    let fakes = fakeLetters.split('');
    let hiddens = hiddenLetters.split('');
    let letters = shuffler((word + fakeLetters).split(''));
    let letterShuffle = '';

    letters.forEach(letter => {
        if (reveal) {
            if (fakes.includes(letter)) {
                letterShuffle +=
                    `<div class="letter shuffle">
                    <ul>
                        <li class="invalid">${letter.normalize('NFD').replace(/[\u0300-\u036f]/g, '')}<span>${wordPoint(letter.normalize('NFD').replace(/[\u0300-\u036f]/g, ''))}</span></li>
                        <li class="">${letter.normalize('NFD').replace(/[\u0300-\u036f]/g, '')}<span>${wordPoint(letter.normalize('NFD').replace(/[\u0300-\u036f]/g, ''))}</span></li>
                    </ul>
                </div>\n`
            } else if (hiddens.includes(letter)) {
                letterShuffle +=
                    `<div class="letter shuffle">
                    <ul>
                        <li class="question">${letter.normalize('NFD').replace(/[\u0300-\u036f]/g, '')}<span>${wordPoint(letter.normalize('NFD').replace(/[\u0300-\u036f]/g, ''))}</span></li>
                        <li class="">${letter.normalize('NFD').replace(/[\u0300-\u036f]/g, '')}<span>${wordPoint(letter.normalize('NFD').replace(/[\u0300-\u036f]/g, ''))}</span></li>
                    </ul>
                </div>\n`
            } else {
                letterShuffle +=
                    `<div class="letter shuffle">
                    <ul>
                        <li class="">${letter.normalize('NFD').replace(/[\u0300-\u036f]/g, '')}<span>${wordPoint(letter.normalize('NFD').replace(/[\u0300-\u036f]/g, ''))}</span></li>
                        <li class="">${letter.normalize('NFD').replace(/[\u0300-\u036f]/g, '')}<span>${wordPoint(letter.normalize('NFD').replace(/[\u0300-\u036f]/g, ''))}</span></li>
                    </ul>
                </div>\n`
            }
        } else {
            if (fakes.includes(letter)) {
                letterShuffle +=
                    `<div class="letter shuffle">
                    <ul>
                        <li class="">${letter.normalize('NFD').replace(/[\u0300-\u036f]/g, '')}<span>${wordPoint(letter.normalize('NFD').replace(/[\u0300-\u036f]/g, ''))}</span></li>
                        <li class="">${letter.normalize('NFD').replace(/[\u0300-\u036f]/g, '')}<span>${wordPoint(letter.normalize('NFD').replace(/[\u0300-\u036f]/g, ''))}</span></li>
                    </ul>
                </div>\n`
            } else if (hiddens.includes(letter)) {
                letterShuffle +=
                    `<div class="letter shuffle">
                    <ul>
                        <li class="question">?<span></span></li>
                        <li class="">?<span></span></li>
                    </ul>
                </div>\n`
            } else {
                letterShuffle +=
                    `<div class="letter shuffle">
                    <ul>
                        <li class="">${letter.normalize('NFD').replace(/[\u0300-\u036f]/g, '')}<span>${wordPoint(letter.normalize('NFD').replace(/[\u0300-\u036f]/g, ''))}</span></li>
                        <li class="">${letter.normalize('NFD').replace(/[\u0300-\u036f]/g, '')}<span>${wordPoint(letter.normalize('NFD').replace(/[\u0300-\u036f]/g, ''))}</span></li>
                    </ul>
                </div>\n`
            }
        }
    });
    return letterShuffle;
}

function shuffler(array) {
    for (let i = array.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [array[i], array[j]] = [array[j], array[i]];
    }
    return array;
}

function updateNick() {
    let editableElements = document.querySelectorAll(".nick");
    editableElements.forEach(element => {
        element.addEventListener("input", (event) => {
            const index = event.target.closest('.nick').dataset.index;
            let json = getList();
            let updatedJson = updateUsernameByIndex(json, index, event.target.innerText);
            saveList(updatedJson);
        });
    });
}

function addHover() {
    let json = getList();
    let arr = [...json.column1, ...json.column2, ...json.column3];
    arr.forEach((elem, index) => {
        let slot = document.getElementById(`ourSlot${index}`);
        let ourLocks = document.getElementById(`ourLock${index}`)
        slot.addEventListener("mouseover", () => {
            if (arr[index].locked) return;
            slot.className = "slot hit";
            ourLocks.className = "padlock";
            ourLocks.style.display = 'flex';
        });
        slot.addEventListener("mouseout", () => {
            if (arr[index].locked) return;
            slot.className = "slot hit expired"
            ourLocks.className = "";
            ourLocks.style.display = 'none';
        });
        ourLocks.addEventListener("click", () => {
            if (arr[index].locked) {
                updateLockStatus(false, index);
                ourLocks.className = "";
                slot.className = "slot hit expired"
            } else {
                updateLockStatus(true, index);
                ourLocks.className = "padlock";
            }
            json = getList();
            arr = [...json.column1, ...json.column2, ...json.column3];
            saveList(json);
        });
    })
}

function updateLockStatus(state, index) {
    let json = getList();
    ["column1", "column2", "column3"].forEach(col => {
        let elem = json[col].find(e => e.index === index);
        if (elem) elem.locked = state;
    });
    saveList(json);
}

copyToClipboard.addEventListener("click", () => {
    let json = getList();
    json.userId = userId;
    fetch('https://WOS-Level-Editor.d3fau4tbot.repl.co/wos', {
        method: 'POST',
        body: JSON.stringify(json),
        headers: {
            'Content-type': 'application/json; charset=UTF-8'
        }
    })
        .then(response => response.text())
        .then(text => {
            console.log(text);
            if (text === 'Success') copyToClipboard.innerText = "Submitted successfully ?";
            else if (text === 'Already there') copyToClipboard.innerText = "Level already submitted ?";
            else if (text === 'Overwrited') copyToClipboard.innerText = "Overwrited successfully ?";
            setTimeout(() => copyToClipboard.innerText = "Submit for a Custom Level", 2000);
        })
        .catch(err => console.error(err));
});

function modifyLanguage(lang) {
    switch (lang) {
        case "English": {
            let json = getList();
            const JSONtxt = document.getElementById('JSONtxt');
            const JSONconfig = document.getElementById('JSONconfig');
            const wordListBelow = document.getElementById('wordListBelow');
            const wordListTxt = document.getElementById('wordListTxt');
            const settingLevel = document.getElementById('settingLevel');
            const settingTime = document.getElementById('settingTime');
            const settingLocks = document.getElementById('settingLocks');
            const settingUnlocked = document.getElementById('settingUnlocked');
            const fakeLettersTxt = document.getElementById('fakeLettersTxt');
            const hiddenLettersTxt = document.getElementById('hiddenLettersTxt');
            const revealTxt = document.getElementById('revealTxt');
            const syncSwitch = document.getElementById('syncSwitch');
            json.lang = "English";
            languageNumber.textContent = "English";
            langUI.textContent = "Language and UI";
            langLanguage.textContent = "Language";
            qr1.textContent = "SCAN THE QR CODE TO JOIN THE GAME";
            qr2.textContent = "ENJOY EXTRA FEATURES!";
            formWords.textContent = "FORM WORDS WITH THE LETTERS BELOW";
            congratulations.textContent = "CONGRATULATIONS!";
            levelCompleted.textContent = "LEVEL COMPLETED!";
            goal.textContent = "GOAL";
            level.textContent = "LEVEL";
            syncTxt.textContent = "Synchronization";
            syncSubTxt.textContent = `Triggers the "Syncing last hits" instead of letters`;
            settingLang.textContent = "Settings";
            easyMode.textContent = "Easy Mode";
            easyModeText.textContent = "Don't know how to use JSON? Turn on easy mode and use the UI to customize";
            if (JSONconfig != null && JSONtxt != null) {
                JSONconfig.textContent = "JSON Config";
                JSONtxt.textContent = "Paste the JSON configuration in order to update the board. Example format below.";
            }
            if (wordListBelow != null && wordListTxt != null) {
                wordListTxt.textContent = "Word List";
                wordListBelow.textContent = "Type words below separated with space. Put a ? to indicate word not found yet.";
            }
            if (settingLevel != null && settingLevel != null && settingTime != null && settingLocks != null && settingUnlocked != null) {
                settingLevel.textContent = "Level";
                settingTime.textContent = "Time";
                settingLocks.textContent = "Locks";
                settingUnlocked.textContent = "Unlocked";
            }
            if (fakeLettersTxt != null && hiddenLettersTxt != null && revealTxt != null) {
                fakeLettersTxt.textContent = "Fake Letters";
                hiddenLettersTxt.textContent = "Hidden Letters";
                revealTxt.textContent = "Reveal";
            }
            if (syncSwitch != null) syncSwitch.textContent = "SYNCING LAST HITS";
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            break;
        }

        case "Português": {
            let json = getList();
            const JSONtxt = document.getElementById('JSONtxt');
            const JSONconfig = document.getElementById('JSONconfig');
            const wordListBelow = document.getElementById('wordListBelow');
            const wordListTxt = document.getElementById('wordListTxt');
            const settingLevel = document.getElementById('settingLevel');
            const settingTime = document.getElementById('settingTime');
            const settingLocks = document.getElementById('settingLocks');
            const settingUnlocked = document.getElementById('settingUnlocked');
            const fakeLettersTxt = document.getElementById('fakeLettersTxt');
            const hiddenLettersTxt = document.getElementById('hiddenLettersTxt');
            const syncSwitch = document.getElementById('syncSwitch');
            json.lang = "Português";
            languageNumber.textContent = "Português";
            langUI.textContent = "Idioma e UI";
            langLanguage.textContent = "Idioma";
            qr1.textContent = "ESCANEIE PARA ENTRAR NA SALA";
            qr2.textContent = "APROVEITE OS RECURSOS EXTRAS";
            formWords.textContent = "FORME PALAVRAS COM AS LETRAS ABAIXO";
            congratulations.textContent = "PARABÉNS!";
            levelCompleted.textContent = "NÍVEL COMPLETADO!";
            goal.textContent = "META";
            level.textContent = "NÍVEL";
            syncTxt.textContent = "Sincronização";
            syncSubTxt.textContent = `Aciona o "Sincronizando" em vez de letras`;
            settingLang.textContent = "Configurações";
            easyMode.textContent = "Modo Fácil";
            easyModeText.textContent = "Não sabe como usar JSON? Ative o modo fácil e use a UI para personalizar";
            if (JSONconfig != null && JSONtxt != null) {
                JSONconfig.textContent = "Config JSON";
                JSONtxt.textContent = "Cole a configuração JSON para atualizar a tela. Exemplo abaixo.";
            }
            if (wordListBelow != null && wordListTxt != null) {
                wordListTxt.textContent = "Lista de palavras";
                wordListBelow.textContent = "Digite abaixo as palavras separadas por um espaço. Coloque um ? para indicar que a palavra ainda não foi encontrada.";
            }
            if (settingLevel != null && settingLevel != null && settingTime != null && settingLocks != null && settingUnlocked != null) {
                settingLevel.textContent = "Nível";
                settingTime.textContent = "Tempo";
                settingLocks.textContent = "Cadeados";
                settingUnlocked.textContent = "Desbloqueado";
            }
            if (fakeLettersTxt != null && hiddenLettersTxt != null && revealTxt != null) {
                fakeLettersTxt.textContent = "Letras Falsas";
                hiddenLettersTxt.textContent = "Letras Escondidas";
                revealTxt.textContent = "Revelar";
            }
            if (syncSwitch != null) syncSwitch.textContent = "SINCRONIZANDO";
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            break;
        }

        case "Français": {
            let json = getList();
            const JSONtxt = document.getElementById('JSONtxt');
            const JSONconfig = document.getElementById('JSONconfig');
            const wordListBelow = document.getElementById('wordListBelow');
            const wordListTxt = document.getElementById('wordListTxt');
            const settingLevel = document.getElementById('settingLevel');
            const settingTime = document.getElementById('settingTime');
            const settingLocks = document.getElementById('settingLocks');
            const settingUnlocked = document.getElementById('settingUnlocked');
            const fakeLettersTxt = document.getElementById('fakeLettersTxt');
            const hiddenLettersTxt = document.getElementById('hiddenLettersTxt');
            const syncSwitch = document.getElementById('syncSwitch');
            json.lang = "Français";
            languageNumber.textContent = "Français";
            langUI.textContent = "Langue et UI";
            langLanguage.textContent = "Langue";
            qr1.textContent = "SCANNEZ LE CODE QR POUR JOUER";
            qr2.textContent = "PROFITEZ DES FONCTIONNALITÉS SUPPLÉMENTAIRES!";
            qr2.style.fontSize = "25px";
            formWords.textContent = "FORMEZ DES MOTS AVEC LES LETTRES CI-DESSOUS";
            congratulations.textContent = "FÉLICITATIONS!";
            levelCompleted.textContent = "NIVEAU COMPLÉTÉ!";
            goal.textContent = "OBJECTIF";
            level.textContent = "NIVEAU";
            syncTxt.textContent = "Synchronisation";
            syncSubTxt.textContent = `Déclanche la "synchronisation des mots" au lieu de celle des lettres.`;
            settingLang.textContent = "Paramètres";
            easyMode.textContent = "Mode simple";
            easyModeText.textContent = "Vous ne savez pas comment utiliser JSON? activez le mode simple et utilisez l'UI pour personnaliser";
            if (JSONconfig != null && JSONtxt != null) {
                JSONconfig.textContent = "Config JSON";
                JSONtxt.textContent = "Collez la configuration JSON pour mettre à jour l'écran. Exemple ci-dessous.";
            }
            if (wordListBelow != null && wordListTxt != null) {
                wordListTxt.textContent = "Liste de mots";
                wordListBelow.textContent = "Tapez les mots ci-dessous séparés par un espace. Mettez un ? pour indiquer que le mot n'a pas encore été trouvé.";
            }
            if (settingLevel != null && settingLevel != null && settingTime != null && settingLocks != null && settingUnlocked != null) {
                settingLevel.textContent = "Niveau";
                settingTime.textContent = "Temps";
                settingLocks.textContent = "Verrous";
                settingUnlocked.textContent = "Débloqué";
            }
            if (fakeLettersTxt != null && hiddenLettersTxt != null && revealTxt != null) {
                fakeLettersTxt.textContent = "Lettres fausses";
                hiddenLettersTxt.textContent = "Lettres cachées";
                revealTxt.textContent = "Révéler";
            }
            if (syncSwitch != null) syncSwitch.textContent = "SYNCHRONISATION";
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            break;
        }

        default: {
            let json = getList();
            const JSONtxt = document.getElementById('JSONtxt');
            const JSONconfig = document.getElementById('JSONconfig');
            const wordListBelow = document.getElementById('wordListBelow');
            const wordListTxt = document.getElementById('wordListTxt');
            const settingLevel = document.getElementById('settingLevel');
            const settingTime = document.getElementById('settingTime');
            const settingLocks = document.getElementById('settingLocks');
            const settingUnlocked = document.getElementById('settingUnlocked');
            const fakeLettersTxt = document.getElementById('fakeLettersTxt');
            const hiddenLettersTxt = document.getElementById('hiddenLettersTxt');
            const revealTxt = document.getElementById('revealTxt');
            const syncSwitch = document.getElementById('syncSwitch');
            json.lang = "English";
            languageNumber.textContent = "English";
            langUI.textContent = "Language and UI";
            langLanguage.textContent = "Language";
            qr1.textContent = "SCAN THE QR CODE TO JOIN THE GAME";
            qr2.textContent = "ENJOY EXTRA FEATURES!";
            formWords.textContent = "FORM WORDS WITH THE LETTERS BELOW";
            congratulations.textContent = "CONGRATULATIONS!";
            levelCompleted.textContent = "LEVEL COMPLETED!";
            goal.textContent = "GOAL";
            level.textContent = "LEVEL";
            settingLang.textContent = "Settings";
            easyMode.textContent = "Easy Mode";
            easyModeText.textContent = "Don't know how to use JSON? Turn on easy mode and use the UI to customize";
            if (JSONconfig != null && JSONtxt != null) {
                JSONconfig.textContent = "JSON Config";
                JSONtxt.textContent = "Paste the JSON configuration in order to update the board. Example format below.";
            }
            if (wordListBelow != null && wordListTxt != null) {
                wordListTxt.textContent = "Word List";
                wordListBelow.textContent = "Type words below separated with space. Put a ? to indicate word not found yet.";
            }
            if (settingLevel != null && settingLevel != null && settingTime != null && settingLocks != null && settingUnlocked != null) {
                settingLevel.textContent = "Level";
                settingTime.textContent = "Time";
                settingLocks.textContent = "Locks";
                settingUnlocked.textContent = "Unlocked";
            }
            if (fakeLettersTxt != null && hiddenLettersTxt != null && revealTxt != null) {
                fakeLettersTxt.textContent = "Fake Letters";
                hiddenLettersTxt.textContent = "Hidden Letters";
                revealTxt.textContent = "Reveal";
            }
            if (syncSwitch != null) syncSwitch.textContent = "SYNCING LAST HITS";
            answerSlots.innerHTML = createBoard(json);
            saveList(json);
            break;
        }
    }
}