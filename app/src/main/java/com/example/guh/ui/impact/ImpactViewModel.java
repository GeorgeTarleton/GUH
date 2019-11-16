package com.example.guh.ui.impact;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class ImpactViewModel extends ViewModel {

    private MutableLiveData<String> mText;

    public ImpactViewModel() {
        mText = new MutableLiveData<>();
        mText.setValue("This is the impact fragment");
    }

    public LiveData<String> getText() {
        return mText;
    }
}